namespace QLVT5
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barBtn_DN = new DevExpress.XtraBars.BarButtonItem();
            barBtnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            barBtnDX = new DevExpress.XtraBars.BarButtonItem();
            barBtnThoatMain = new DevExpress.XtraBars.BarButtonItem();
            ribHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribQLTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            tab1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tab1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barBtn_DN, barBtnTaoTK, barBtnDX, barBtnThoatMain });
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            ribbonControl1.MaxItemId = 7;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 660;
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribHeThong, ribDanhMuc });
            ribbonControl1.Size = new System.Drawing.Size(1462, 308);
            // 
            // barBtn_DN
            // 
            barBtn_DN.Caption = "Đăng Nhập";
            barBtn_DN.Id = 1;
            barBtn_DN.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barBtn_DN.ImageOptions.LargeImage");
            barBtn_DN.Name = "barBtn_DN";
            //barBtn_DN.ItemClick += this.barBtn_DN_ItemClick;
            // 
            // barBtnTaoTK
            // 
            barBtnTaoTK.Caption = "Tạo Tài Khoản";
            barBtnTaoTK.Id = 2;
            barBtnTaoTK.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barBtnTaoTK.ImageOptions.LargeImage");
            barBtnTaoTK.Name = "barBtnTaoTK";
            barBtnTaoTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barBtnDX
            // 
            barBtnDX.Caption = "Đăng Xuất";
            barBtnDX.Id = 5;
            barBtnDX.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barBtnDX.ImageOptions.LargeImage");
            barBtnDX.Name = "barBtnDX";
            barBtnDX.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing;
            // 
            // barBtnThoatMain
            // 
            barBtnThoatMain.Caption = "Thoát";
            barBtnThoatMain.Id = 6;
            barBtnThoatMain.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barBtnThoatMain.ImageOptions.LargeImage");
            barBtnThoatMain.Name = "barBtnThoatMain";
            // 
            // ribHeThong
            // 
            ribHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribQLTK });
            ribHeThong.Name = "ribHeThong";
            ribHeThong.Text = "Hệ Thống";
            // 
            // ribQLTK
            // 
            ribQLTK.ItemLinks.Add(barBtn_DN);
            ribQLTK.ItemLinks.Add(barBtnDX);
            ribQLTK.ItemLinks.Add(barBtnTaoTK);
            ribQLTK.ItemLinks.Add(barBtnThoatMain);
            ribQLTK.Name = "ribQLTK";
            ribQLTK.Text = "Quản Lý Tài Khoản";
            // 
            // ribDanhMuc
            // 
            ribDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            ribDanhMuc.Name = "ribDanhMuc";
            ribDanhMuc.Text = "Danh Mục";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // tab1
            // 
            tab1.MdiParent = this;
            // 
            // fmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1462, 977);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "fmMain";
            Ribbon = ribbonControl1;
            RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible;
            Text = "Trang Chủ Quản Lý Vật Tư";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tab1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribQLTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtn_DN;
        private DevExpress.XtraBars.BarButtonItem barBtnTaoTK;
        private DevExpress.XtraBars.BarButtonItem barBtnDX;
        private DevExpress.XtraBars.BarButtonItem barBtnThoatMain;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tab1;
    }
}

