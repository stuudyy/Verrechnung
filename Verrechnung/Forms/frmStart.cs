using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verrechnung.Forms;

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
        internal Color btnBackColor = Color.DarkSlateGray;
        internal Color btnForeColor = Color.White;


        internal frmArtikel frmArt;
        internal frmKunde frmKun;
        internal frmRechnung frmRech;
        internal frmStatistik frmStat;
        internal frmUmsatzsteuer frmUst;
        internal frmWarenkorb frmWk;

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
                b.BackColor = btnBackColor;
                b.ForeColor = btnForeColor;
            }
        }

 #region Methoden
        internal void button_ZuClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    Button btn = (Button)sender;

                    if(btn==btnArtikel)
                    {
                        if (frmArt != null)
                        {
                            frmArt.Close();
                        }
                    }
                    if(btn == btnKunde)
                    {
                        if (frmKun != null)
                            frmKun.Close();
                    }
                    if(btn == btnRechnung)
                    {
                        if (frmRech != null)
                            frmRech.Close();
                    }
                    if(btn == btnStatistik)
                    {
                        if(frmStat != null)
                        {
                            frmStat.Close();
                        }
                    }
                    if(btn == btnUmsatzsteuer)
                    {
                        if (frmUst != null)
                            frmUst.Close();
                    }
                    if(btn==btnWarenkorb)
                    {
                        if(frmWk!=null)
                        {
                            frmWk.Close();
                        }
                    }
                        
                            
                    
                    break;
            }
        }
       
        #endregion

        private void btnWarenkorb_Click(object sender, EventArgs e)
        {
            if(frmWk != null)
            {
                frmWk.BringToFront();
            }
            else
            {
                btnWarenkorb.BackColor = btnForeColor;
                btnWarenkorb.ForeColor = btnBackColor;
                frmWk = new frmWarenkorb();
                frmWk.Text = "Warenkorb";
                frmWk.Show();
            }
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            if(frmArt != null)
            {
                frmArt.BringToFront();
            }
            else
            {
                btnArtikel.BackColor = btnForeColor;
                btnArtikel.ForeColor = btnBackColor;
                frmArt = new frmArtikel();
                frmArt.Text = "Artikelverwaltung";
                frmArt.Show();

            }
        }

        private void btnKunde_Click(object sender, EventArgs e)
        {
            if (frmKun != null)
            {
                frmKun.BringToFront();
            }
            else
            {
                btnKunde.BackColor = Color.White;
                btnKunde.ForeColor = btnBackColor;
                frmKun = new frmKunde();
                frmKun.Text = "Kundenverwaltung";
                frmKun.Show();

            }
        }

        private void btnRechnung_Click(object sender, EventArgs e)
        {
            if(frmRech != null)
            {
                frmRech.BringToFront();
            }
            else
            {
                btnRechnung.BackColor = btnForeColor;
                btnRechnung.ForeColor = btnBackColor;
                frmRech = new frmRechnung();
                frmRech.Text = "Rechnungsverwaltung";
                frmRech.Show();
            }
        }

        private void btnUmsatzsteuer_Click(object sender, EventArgs e)
        {
            if(frmUst != null)
            {
                frmUst.BringToFront();
            }
            else
            {
                btnUmsatzsteuer.BackColor = btnForeColor;
                btnUmsatzsteuer.ForeColor = btnBackColor;
                frmUst = new frmUmsatzsteuer();
                frmUst.Text = "Umsatzsteuer-Verwaltung";
                frmUst.Show();
            }
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            if (frmStat != null)
            {
                frmStat.BringToFront();
            }
            else
            {
                btnStatistik.BackColor = btnForeColor;
                btnStatistik.ForeColor = btnBackColor;
                frmStat = new frmStatistik();
                frmStat.Text = "Statistik";
                frmStat.Show();
            }
        }

        private void btnAlleSchließen_Click(object sender, EventArgs e)
        {
            if (frmWk != null) frmWk.Close();
            if (frmArt != null) frmArt.Close();
            if (frmKun != null) frmKun.Close();
            if (frmRech != null) frmRech.Close();
            if (frmStat != null) frmStat.Close();
            if (frmUst != null) frmUst.Close();
        }

        private void btnProgrammSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
