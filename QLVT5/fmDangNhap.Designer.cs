using System.Windows.Forms;

namespace QLVT5
{
    partial class fmDangNhap
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDangNhap));
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            textTenDN = new System.Windows.Forms.TextBox();
            textMatKhau = new System.Windows.Forms.TextBox();
            labelDangNhap = new System.Windows.Forms.Label();
            labelTenDN = new System.Windows.Forms.Label();
            labelMatKhau = new System.Windows.Forms.Label();
            picDangNhap = new DevExpress.XtraEditors.PictureEdit();
            btnDangNhap = new System.Windows.Forms.Button();
            labelDN_VaiTro = new System.Windows.Forms.Label();
            radioDN_Admin = new System.Windows.Forms.RadioButton();
            radioDN_NhanVien = new System.Windows.Forms.RadioButton();
            btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)picDangNhap.Properties).BeginInit();
            SuspendLayout();
            // 
            // textTenDN
            // 
            textTenDN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            textTenDN.Location = new System.Drawing.Point(936, 392);
            textTenDN.Name = "textTenDN";
            textTenDN.Size = new System.Drawing.Size(435, 46);
            textTenDN.TabIndex = 0;
            // 
            // textMatKhau
            // 
            textMatKhau.CausesValidation = false;
            textMatKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            textMatKhau.Location = new System.Drawing.Point(936, 484);
            textMatKhau.Name = "textMatKhau";
            textMatKhau.PasswordChar = '*';
            textMatKhau.Size = new System.Drawing.Size(439, 46);
            textMatKhau.TabIndex = 1;
            //textMatKhau.TextChanged += textMatKhau_TextChanged;

            // 
            // labelDangNhap
            // 
            labelDangNhap.AutoSize = true;
            labelDangNhap.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            labelDangNhap.ForeColor = System.Drawing.Color.Firebrick;
            labelDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            labelDangNhap.Location = new System.Drawing.Point(867, 215);
            labelDangNhap.Name = "labelDangNhap";
            labelDangNhap.Size = new System.Drawing.Size(263, 52);
            labelDangNhap.TabIndex = 2;
            labelDangNhap.Text = "Đăng Nhập";
            labelDangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTenDN
            // 
            labelTenDN.AutoSize = true;
            labelTenDN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTenDN.Location = new System.Drawing.Point(659, 399);
            labelTenDN.Name = "labelTenDN";
            labelTenDN.Size = new System.Drawing.Size(252, 39);
            labelTenDN.TabIndex = 3;
            labelTenDN.Text = "Tên đăng nhập";
            // 
            // labelMatKhau
            // 
            labelMatKhau.AutoSize = true;
            labelMatKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            labelMatKhau.Location = new System.Drawing.Point(663, 491);
            labelMatKhau.Name = "labelMatKhau";
            labelMatKhau.Size = new System.Drawing.Size(165, 39);
            labelMatKhau.TabIndex = 4;
            labelMatKhau.Text = "Mật khẩu";
            //labelMatKhau.Click += labelMatKhau_Click;
            // 
            // picDangNhap
            // 
            picDangNhap.EditValue = resources.GetObject("picDangNhap.EditValue");
            picDangNhap.Location = new System.Drawing.Point(-14, 0);
            picDangNhap.Name = "picDangNhap";
            picDangNhap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            picDangNhap.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            picDangNhap.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            picDangNhap.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            picDangNhap.Size = new System.Drawing.Size(580, 885);


            picDangNhap.TabIndex = 5;
            //picDangNhap.EditValueChanged += picDangNhap_EditValueChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDangNhap.Location = new System.Drawing.Point(750, 563);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new System.Drawing.Size(230, 62);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // labelDN_VaiTro
            // 
            labelDN_VaiTro.AutoSize = true;
            labelDN_VaiTro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelDN_VaiTro.Location = new System.Drawing.Point(663, 304);
            labelDN_VaiTro.Name = "labelDN_VaiTro";
            labelDN_VaiTro.Size = new System.Drawing.Size(124, 39);
            labelDN_VaiTro.TabIndex = 7;
            labelDN_VaiTro.Text = "Vai trò";
            //labelDN_VaiTro.Click += labelDn_VaiTro_Click;
            // 
            // radioDN_Admin
            // 
            radioDN_Admin.AutoSize = true;
            radioDN_Admin.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Italic);
            radioDN_Admin.Location = new System.Drawing.Point(936, 304);
            radioDN_Admin.Name = "radioDN_Admin";
            radioDN_Admin.Size = new System.Drawing.Size(126, 39);
            radioDN_Admin.TabIndex = 8;
            radioDN_Admin.TabStop = true;
            radioDN_Admin.Text = "Admin";
            radioDN_Admin.UseVisualStyleBackColor = true;
            //radioDN_Admin.CheckedChanged += radioDN_Admin_CheckedChanged;
            // 
            // radioDN_NhanVien
            // 
            radioDN_NhanVien.AutoSize = true;
            radioDN_NhanVien.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Italic);
            radioDN_NhanVien.Location = new System.Drawing.Point(1195, 303);
            radioDN_NhanVien.Name = "radioDN_NhanVien";
            radioDN_NhanVien.Size = new System.Drawing.Size(176, 39);
            radioDN_NhanVien.TabIndex = 9;
            radioDN_NhanVien.TabStop = true;
            radioDN_NhanVien.Text = "Nhân Viên";
            radioDN_NhanVien.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnThoat.Location = new System.Drawing.Point(1054, 563);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(230, 62);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // fmDangNhap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1429, 880);
            Controls.Add(btnThoat);
            Controls.Add(radioDN_NhanVien);
            Controls.Add(radioDN_Admin);
            Controls.Add(labelDN_VaiTro);
            Controls.Add(btnDangNhap);
            Controls.Add(picDangNhap);
            Controls.Add(labelMatKhau);
            Controls.Add(labelTenDN);
            Controls.Add(labelDangNhap);
            Controls.Add(textMatKhau);
            Controls.Add(textTenDN);
            Name = "fmDangNhap";
            Text = "fmDangNhap";
            //Load += fmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)picDangNhap.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.TextBox textTenDN;
        private System.Windows.Forms.TextBox textMatKhau;
        private System.Windows.Forms.Label labelDangNhap;
        private System.Windows.Forms.Label labelTenDN;
        private System.Windows.Forms.Label labelMatKhau;
        private DevExpress.XtraEditors.PictureEdit picDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label labelDN_VaiTro;
        private System.Windows.Forms.RadioButton radioDN_Admin;
        private System.Windows.Forms.RadioButton radioDN_NhanVien;
        private System.Windows.Forms.Button btnThoat;
    }
}