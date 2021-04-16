using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verrechnung.Forms
{
    public partial class frmWarenkorb : Form
    {
        public frmWarenkorb()
        {
            InitializeComponent();
        }

        private void frmWarenkorb_Load(object sender, EventArgs e)
        {
            this.Height = frmStart.f1.displayHeight;
            this.Width = frmStart.f1.Width * 4;
            this.Location = new Point(frmStart.f1.Width, 0);
            this.BackColor = frmStart.f1.btnBackColor;
        }

        private void frmWarenkorb_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart.f1.btnWarenkorb.BackColor = frmStart.f1.btnBackColor;
            frmStart.f1.btnWarenkorb.ForeColor = frmStart.f1.btnForeColor;
            frmStart.f1.frmWk = null;
        }
    }
}
