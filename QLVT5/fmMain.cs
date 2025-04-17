using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT5
{
    public partial class fmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        //private void btnNhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Form frm = this.CheckExists(typeof(frmNhanvien));
        //    if (frm != null) frm.Activate();
        //    else
        //    {
        //        frmNhanvien f = new frmNhanvien();
        //        f.MdiParent = this;
        //        f.Show();
        //    }
        //}

        public fmMain()
        {
            InitializeComponent();

        }

    }
}
