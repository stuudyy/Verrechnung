using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verrechnung
{
    public partial class frmStart : Form
    {
        internal static frmStart f1;

        public frmStart()
        {
            f1 = this;
            InitializeComponent();
        }

        #region Variablen
        internal int displayWidth;
        internal int displayHeight;
        internal int buttonHeight;
        internal Button[] buttons;
        internal Color buttonColor = Color.DarkSlateGray;
        #endregion

        private void frmStart_Load(object sender, EventArgs e)
        {
            displayWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            displayHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = displayWidth / 5;
            this.Height = displayHeight;
            buttonHeight = (displayHeight - 30) / 8;
            buttons = new Button[] { btnWarenkorb, btnArtikel, btnKunde, btnRechnung, btnUmsatzsteuer, btnStatistik, btnAlleSchließen, btnProgrammSchließen };

            int xpos = 0;
            int ypos = 0;

            foreach(Button b in buttons)
            {
                b.Width = this.Width - 15;
                b.Height = buttonHeight;
                b.Location = new Point(xpos, ypos);
                ypos = ypos + buttonHeight;
                b.Font = new Font("Arial", 14, FontStyle.Bold);
                b.BackColor = buttonColor;
                b.ForeColor = Color.White;
            }
        }

        

        #region Methoden
        #endregion

    }
}
