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
    public partial class frmArtikel : Form
    {
        public frmArtikel()
        {
            InitializeComponent();
        }
        string sql;


        private void frmArtikel_Load(object sender, EventArgs e)
        {
            //frmArtikel am Bildschirm/ frmStart ausrichten
            this.Height = frmStart.f1.displayHeight;
            this.Width = frmStart.f1.Width * 4;
            this.Location = new Point(frmStart.f1.Width, 0);
            this.BackColor = frmStart.f1.btnBackColor;

            //panels ein/ausrichten
            panel1.Width = this.Width / 5 * 3;
            panel2.Width = this.Width / 5 * 2;
            panel1.Height = this.Height;
            panel2.Height = this.Height;
            //panel1.BackColor = Color.Gray;
            //panel2.BackColor = Color.DarkGray;
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(panel1.Width, 0);

            //listview einrichten
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Columns.Add("ArtikelID");
            listView1.Columns.Add("Bezeichnung");
            listView1.Columns.Add("Nettopreis");
            listView1.Columns.Add("UmsatzsteuerID");
            listView1.Font = new Font("Arial", 12, FontStyle.Bold);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            Datenbank db = new Datenbank();
            sql = "Select a.ArtikelID, a.Bezeichnung, a.Nettopreis, u.UstSatu from Artikel a, Umsatzsteuer u WHERE a.UmsatzsteuerID = u.UmsatzsteuerID";
        }

        private void einlesenArtikel()
        {
            listView1.Items.Clear();

        }


        private void frmArtikel_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart.f1.btnArtikel.BackColor = frmStart.f1.btnBackColor;
            frmStart.f1.btnArtikel.ForeColor = frmStart.f1.btnForeColor;
            frmStart.f1.frmArt = null;
        }
    }
}
