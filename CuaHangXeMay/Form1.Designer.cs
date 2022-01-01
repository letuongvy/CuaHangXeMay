
namespace CuaHangXeMay
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabXe = new System.Windows.Forms.TabPage();
            this.dataGridViewXe = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThoatxe = new System.Windows.Forms.Button();
            this.txtSokhung = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.txtSomay = new System.Windows.Forms.TextBox();
            this.cmbMaNX = new System.Windows.Forms.ComboBox();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMau = new System.Windows.Forms.Label();
            this.lblSomay = new System.Windows.Forms.Label();
            this.lblMaNX = new System.Windows.Forms.Label();
            this.tabNhanvien = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXe)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabNhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabXe);
            this.tabControl1.Controls.Add(this.tabNhanvien);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabXe
            // 
            this.tabXe.Controls.Add(this.dataGridViewXe);
            this.tabXe.Controls.Add(this.panel3);
            this.tabXe.Location = new System.Drawing.Point(4, 25);
            this.tabXe.Name = "tabXe";
            this.tabXe.Padding = new System.Windows.Forms.Padding(3);
            this.tabXe.Size = new System.Drawing.Size(921, 421);
            this.tabXe.TabIndex = 1;
            this.tabXe.Text = "Quản lý xe";
            this.tabXe.UseVisualStyleBackColor = true;
            // 
            // dataGridViewXe
            // 
            this.dataGridViewXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXe.Location = new System.Drawing.Point(7, 191);
            this.dataGridViewXe.Name = "dataGridViewXe";
            this.dataGridViewXe.RowHeadersWidth = 51;
            this.dataGridViewXe.RowTemplate.Height = 24;
            this.dataGridViewXe.Size = new System.Drawing.Size(914, 219);
            this.dataGridViewXe.TabIndex = 1;
            this.dataGridViewXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThoatxe);
            this.panel3.Controls.Add(this.txtSokhung);
            this.panel3.Controls.Add(this.txtGia);
            this.panel3.Controls.Add(this.txtMau);
            this.panel3.Controls.Add(this.txtSomay);
            this.panel3.Controls.Add(this.cmbMaNX);
            this.panel3.Controls.Add(this.btnKhoiTao);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.lblGia);
            this.panel3.Controls.Add(this.lblMau);
            this.panel3.Controls.Add(this.lblSomay);
            this.panel3.Controls.Add(this.lblMaNX);
            this.panel3.Location = new System.Drawing.Point(7, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 179);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnThoatxe
            // 
            this.btnThoatxe.Location = new System.Drawing.Point(697, 106);
            this.btnThoatxe.Name = "btnThoatxe";
            this.btnThoatxe.Size = new System.Drawing.Size(75, 23);
            this.btnThoatxe.TabIndex = 22;
            this.btnThoatxe.Text = "Exit";
            this.btnThoatxe.UseVisualStyleBackColor = true;
            this.btnThoatxe.Click += new System.EventHandler(this.btnThoatxe_Click);
            // 
            // txtSokhung
            // 
            this.txtSokhung.Location = new System.Drawing.Point(697, 14);
            this.txtSokhung.Name = "txtSokhung";
            this.txtSokhung.Size = new System.Drawing.Size(173, 22);
            this.txtSokhung.TabIndex = 21;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(425, 63);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(173, 22);
            this.txtGia.TabIndex = 20;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(425, 14);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(173, 22);
            this.txtMau.TabIndex = 19;
            // 
            // txtSomay
            // 
            this.txtSomay.Location = new System.Drawing.Point(143, 63);
            this.txtSomay.Name = "txtSomay";
            this.txtSomay.Size = new System.Drawing.Size(173, 22);
            this.txtSomay.TabIndex = 18;
            // 
            // cmbMaNX
            // 
            this.cmbMaNX.FormattingEnabled = true;
            this.cmbMaNX.Items.AddRange(new object[] {
            "Exciter",
            "Lead",
            "Siri"});
            this.cmbMaNX.Location = new System.Drawing.Point(143, 18);
            this.cmbMaNX.Name = "cmbMaNX";
            this.cmbMaNX.Size = new System.Drawing.Size(173, 24);
            this.cmbMaNX.TabIndex = 17;
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Location = new System.Drawing.Point(566, 106);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btnKhoiTao.TabIndex = 16;
            this.btnKhoiTao.Text = "Reset";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Nhóm Xe";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(289, 106);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(425, 106);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(156, 106);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(358, 66);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(57, 17);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "Đơn giá";
            // 
            // lblMau
            // 
            this.lblMau.AutoSize = true;
            this.lblMau.Location = new System.Drawing.Point(358, 17);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(61, 17);
            this.lblMau.TabIndex = 2;
            this.lblMau.Text = "Màu sắc";
            // 
            // lblSomay
            // 
            this.lblSomay.AutoSize = true;
            this.lblSomay.Location = new System.Drawing.Point(23, 66);
            this.lblSomay.Name = "lblSomay";
            this.lblSomay.Size = new System.Drawing.Size(55, 17);
            this.lblSomay.TabIndex = 1;
            this.lblSomay.Text = "Số Máy";
            // 
            // lblMaNX
            // 
            this.lblMaNX.AutoSize = true;
            this.lblMaNX.Location = new System.Drawing.Point(623, 17);
            this.lblMaNX.Name = "lblMaNX";
            this.lblMaNX.Size = new System.Drawing.Size(68, 17);
            this.lblMaNX.TabIndex = 0;
            this.lblMaNX.Text = "Số khung";
            // 
            // tabNhanvien
            // 
            this.tabNhanvien.Controls.Add(this.dataGridView2);
            this.tabNhanvien.Controls.Add(this.panel2);
            this.tabNhanvien.Location = new System.Drawing.Point(4, 25);
            this.tabNhanvien.Name = "tabNhanvien";
            this.tabNhanvien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanvien.Size = new System.Drawing.Size(921, 421);
            this.tabNhanvien.TabIndex = 2;
            this.tabNhanvien.Text = "Quản lý Nhân viên";
            this.tabNhanvien.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 194);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(897, 203);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 182);
            this.panel2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(921, 421);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Quản lý nhập hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(921, 421);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Quản lý xuất hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(921, 421);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Quản lý nhà cung cấp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(921, 421);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "Thống kê";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "FrmQuanLySalonXM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXe)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabNhanvien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabXe;
        private System.Windows.Forms.DataGridView dataGridViewXe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabNhanvien;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMau;
        private System.Windows.Forms.Label lblSomay;
        private System.Windows.Forms.Label lblMaNX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.TextBox txtSokhung;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.TextBox txtSomay;
        private System.Windows.Forms.ComboBox cmbMaNX;
        private System.Windows.Forms.Button btnThoatxe;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}