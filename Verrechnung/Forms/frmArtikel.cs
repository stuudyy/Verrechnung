using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Verrechnung.Forms
{
    public partial class frmArtikel : Form
    {
        public frmArtikel()
        {
            InitializeComponent();
        }
        string sql;
        ListViewItem lvItem;
        OleDbDataReader dr;
        Datenbank db;
        List<int> listUst;



        private void frmArtikel_Load(object sender, EventArgs e)
        {
            
            
            //frmArtikel am Bildschirm/ frmStart ausrichten
            this.Height = frmStart.f1.displayHeight;
            this.Width = frmStart.f1.Width * 4;
            this.Location = new Point(frmStart.f1.Width, 0);
            this.BackColor = frmStart.f1.btnBackColor;
            btnSpeichern.ForeColor = frmStart.f1.btnBackColor;
            btnSpeichern.BackColor = frmStart.f1.btnForeColor;

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

            db = new Datenbank();

            listUst = new List<int>();

            einlesenArtikel();
            einlesenUst();
            cbUmsatzsteuer.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbUmsatzsteuer.AutoCompleteSource = AutoCompleteSource.ListItems;



        }

        private void einlesenArtikel()
        {
            listView1.Items.Clear();
            sql = "Select a.ArtikelID, a.Bezeichnung, a.Nettopreis, u.UstSatz from Artikel a, Umsatzsteuer u WHERE a.UmsatzsteuerID = u.UmsatzsteuerID"; 
            
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                lvItem.SubItems.Add(dr[2].ToString());
                lvItem.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(lvItem);

            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        internal void einlesenUst()
        {
            cbUmsatzsteuer.Items.Clear();
            sql = "Select * from Umsatzsteuer";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                cbUmsatzsteuer.Items.Add(dr[0].ToString());
                
            }
        }


        private void frmArtikel_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart.f1.btnArtikel.BackColor = frmStart.f1.btnBackColor;
            frmStart.f1.btnArtikel.ForeColor = frmStart.f1.btnForeColor;
            frmStart.f1.frmArt = null;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Bitte waehlen Sie einen Artikel aus!");
            //    return;
            //}
            lvItem = listView1.SelectedItems[0];
            label1.Text = "Artikel bearbeiten";
            txtArtikelID.Text = lvItem.SubItems[0].Text;
            txtBezeichnung.Text = lvItem.SubItems[1].Text;
            txtNettopreis.Text = lvItem.SubItems[2].Text;
            cbUmsatzsteuer.Text = lvItem.SubItems[3].Text;

            cbNeuanlage.Checked = false;
        }

        private void cbNeuanlage_Click(object sender, EventArgs e)
        {
            if(cbNeuanlage.Checked)
            {
                int artID = db.BerechnenInt("Select Max(ArtikelID) from Artikel") + 1;
                label1.Text = "Artikel anlegen";
                txtArtikelID.Text = artID.ToString();
                txtBezeichnung.Clear();
                txtNettopreis.Clear();
                cbUmsatzsteuer.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Wenn Sie einen Artikel bearbeiten wollen, klicken Sie auf diesen!");
                cbNeuanlage.Checked = true;
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            double preis = 0;
            if (txtBezeichnung.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie eine Bezeichnung ein!");
                return;
            }
            try
            {
                preis = Double.Parse(txtNettopreis.Text, System.Globalization.NumberStyles.Currency);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie einen gueltigen Preis ein!");
                return;
            }
            if (cbUmsatzsteuer.SelectedIndex==-1)
            {
                MessageBox.Show("Bitte waehlen Sie einen Umsatz-Steuersatz aus!");
                return;
            }
            if(cbNeuanlage.Checked)
            {
                try
                {
                    sql = "Insert into Artikel (Bezeichnung, Nettopreis, UstSatz) values ('" + txtBezeichnung.Text + "', " + preis + ", " + listUst[cbUmsatzsteuer.SelectedIndex] + ")";
                    MessageBox.Show(sql);
                    db.Ausführen(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    sql = "Update Artikel set Bezeichnung = '" + txtBezeichnung.Text + "', Nettopreis = " + preis + ", UmsatzsteuerID = " + listUst[cbUmsatzsteuer.SelectedIndex] + " WHERE ArtikelID = " + Convert.ToInt16(txtArtikelID.Text);
                    MessageBox.Show(sql);
                    db.Ausführen(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
