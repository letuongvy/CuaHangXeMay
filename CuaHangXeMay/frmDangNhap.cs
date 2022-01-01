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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btDongy_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6KOCH5Q\SQLEXPRESS;Initial Catalog=QLXeMay;Integrated Security=True");
           
                con.Open();
                string tk = txttkhoan.Text;
                string mk = txtmatkhau.Text;
                string Err = string.Empty;
                if (tk == string.Empty)
                    Err = "Vui lòng nhập tên đăng nhập!";
                if (mk == string.Empty)
                    Err += "\n Vui lòng nhập mật khẩu!";
                if(Err!= string.Empty)
                {
                    MessageBox.Show("Error: " + Err);
                    return;
                }
                try
                {
                    string sql = "select * from TaiKhoan where Username = '" + txttkhoan.Text + "'and Password ='" + txtmatkhau.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.Read() == true)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    Form1 frmXe = new Form1();
                    frmXe.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không hợp lệ");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
            

        private void btBoqua_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
