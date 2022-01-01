
namespace CuaHangXeMay
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            this.btBoqua = new System.Windows.Forms.Button();
            this.btDongy = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttkhoan = new System.Windows.Forms.TextBox();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(337, 155);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(75, 30);
            this.btBoqua.TabIndex = 26;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // btDongy
            // 
            this.btDongy.Location = new System.Drawing.Point(214, 155);
            this.btDongy.Name = "btDongy";
            this.btDongy.Size = new System.Drawing.Size(107, 30);
            this.btDongy.TabIndex = 25;
            this.btDongy.Text = "Đăng nhập";
            this.btDongy.UseVisualStyleBackColor = true;
            this.btDongy.Click += new System.EventHandler(this.btDongy_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(170, 107);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(242, 22);
            this.txtmatkhau.TabIndex = 24;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttkhoan
            // 
            this.txttkhoan.Location = new System.Drawing.Point(170, 59);
            this.txttkhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txttkhoan.Name = "txttkhoan";
            this.txttkhoan.Size = new System.Drawing.Size(242, 22);
            this.txttkhoan.TabIndex = 23;
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.Location = new System.Drawing.Point(42, 107);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(70, 17);
            this.lblMatkhau.TabIndex = 22;
            this.lblMatkhau.Text = "Mật khẩu:";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Location = new System.Drawing.Point(42, 59);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(109, 17);
            this.lblTenDN.TabIndex = 21;
            this.lblTenDN.Text = "Tên đăng nhập:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBoqua);
            this.Controls.Add(this.btDongy);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttkhoan);
            this.Controls.Add(this.lblMatkhau);
            this.Controls.Add(this.lblTenDN);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.Button btDongy;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttkhoan;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}