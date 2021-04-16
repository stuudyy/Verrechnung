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
    public partial class frmRechnung : Form
    {
        public frmRechnung()
        {
            InitializeComponent();
        }

        private void frmRechnung_Load(object sender, EventArgs e)
        {
            this.Height = frmStart.f1.displayHeight;
            this.Width = frmStart.f1.Width * 4;
            this.Location = new Point(frmStart.f1.Width, 0);
            this.BackColor = frmStart.f1.btnBackColor;
        }

        private void frmRechnung_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart.f1.btnRechnung.BackColor = frmStart.f1.btnBackColor;
            frmStart.f1.btnRechnung.ForeColor = frmStart.f1.btnForeColor;
            frmStart.f1.frmRech = null;
        }
    }
}
