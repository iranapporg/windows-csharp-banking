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
    public partial class frmpatch : Form
    {
        public frmpatch()
        {
            InitializeComponent();
        }

        private void frmpatch_Load(object sender, EventArgs e)
        {
            frmmdi f1 = new frmmdi();
            if (key_Software1.GetRegister())
            {

                this.Dispose(false);
                f1.Show();

            }
            else
                return;
        }
    }
}
