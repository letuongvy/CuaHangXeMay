using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CuaHangXeMay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection connection;
        SqlCommand command;
        string chuoiketnoi = @"Data Source=DESKTOP-6KOCH5Q\SQLEXPRESS;Initial Catalog=QLXeMay;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        

        public void hienthi()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Xe";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewXe.DataSource = table;
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            hienthi();
            //hienthiNhom();
        }

        private void tabNhomxe_Click(object sender, EventArgs e)
        {

        }

        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ràng buộc không thể sửa số máy đc
            //txtSomay.ReadOnly = true;
            int i;
            i = dataGridViewXe.CurrentRow.Index;
            cmbMaNX.Text = dataGridViewXe.Rows[i].Cells[1].Value.ToString();
            txtSomay.Text = dataGridViewXe.Rows[i].Cells[0].Value.ToString();
            txtMau.Text = dataGridViewXe.Rows[i].Cells[2].Value.ToString();
            txtGia.Text = dataGridViewXe.Rows[i].Cells[3].Value.ToString();
            txtSokhung.Text = dataGridViewXe.Rows[i].Cells[4].Value.ToString();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Xe values ('" + txtSomay.Text + "',N'" + cmbMaNX.Text + "', N'" + txtMau.Text + "','" + txtGia.Text + "','" + txtSokhung.Text + "')";
            command.ExecuteNonQuery();
            hienthi();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Xe where SoMay = '" + txtSomay.Text + "'";
            command.ExecuteNonQuery();
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Xe set MaNhomXe= N'" + cmbMaNX.Text + "', MauSac= N'" + txtMau.Text + "', DonGia= " + txtGia.Text + ", SoKhung= '" + txtSokhung.Text + "' where SoMay= '" + txtSomay.Text + "'";
            command.ExecuteNonQuery();
            hienthi();
        }
        /// <summary>
        /// Khởi tạo lại dữ liệu textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtSomay.Text = "";
            cmbMaNX.Text = "";
            txtMau.Text = "";
            txtGia.Text = "";
            txtSokhung.Text = "";

        }

        private void txtMaNXe_TextChanged(object sender, EventArgs e)
        {

        }

       
       

        private void btnThoatxe_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
