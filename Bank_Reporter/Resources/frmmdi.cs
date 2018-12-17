using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank_Reporter
{
    public partial class frmmdi : Form{
    
        frmmenu frmm1 = new frmmenu();
        frmbranch frmbranch1 = new frmbranch();
        public static frmmdi frmMain;

        db db1 = new db();
        public frmmdi()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void frmmdi_Load(object sender, EventArgs e)
        {
            int i = db1.countRecord("SELECT Count(*) FROM tbl_branch");
            if (i < 1)
            {
                frmbranch1.MdiParent = this;
                frmbranch1.Show();
            }
            frmm1.MdiParent = this;
            frmm1.Show();
            frmmdi.frmMain = this;
 
          
        }

        private void frmmdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (MessageBox.Show("آیا مایل به خروج هستید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.ExitThread();
        }
    }
}
