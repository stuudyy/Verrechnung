namespace Verrechnung.Forms
{
    partial class frmArtikel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbNeuanlage = new System.Windows.Forms.CheckBox();
            this.cbUmsatzsteuer = new System.Windows.Forms.ComboBox();
            this.txtBezeichnung = new System.Windows.Forms.TextBox();
            this.txtNettopreis = new System.Windows.Forms.TextBox();
            this.txtArtikelID = new System.Windows.Forms.TextBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 320);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(465, 320);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbNeuanlage);
            this.panel2.Controls.Add(this.cbUmsatzsteuer);
            this.panel2.Controls.Add(this.txtBezeichnung);
            this.panel2.Controls.Add(this.txtNettopreis);
            this.panel2.Controls.Add(this.txtArtikelID);
            this.panel2.Controls.Add(this.btnSpeichern);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(497, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 425);
            this.panel2.TabIndex = 1;
            // 
            // cbNeuanlage
            // 
            this.cbNeuanlage.AutoSize = true;
            this.cbNeuanlage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNeuanlage.Location = new System.Drawing.Point(6, 259);
            this.cbNeuanlage.Name = "cbNeuanlage";
            this.cbNeuanlage.Size = new System.Drawing.Size(103, 20);
            this.cbNeuanlage.TabIndex = 11;
            this.cbNeuanlage.Text = "Neuanlage";
            this.cbNeuanlage.UseVisualStyleBackColor = true;
            this.cbNeuanlage.Click += new System.EventHandler(this.cbNeuanlage_Click);
            // 
            // cbUmsatzsteuer
            // 
            this.cbUmsatzsteuer.FormattingEnabled = true;
            this.cbUmsatzsteuer.Location = new System.Drawing.Point(125, 190);
            this.cbUmsatzsteuer.Name = "cbUmsatzsteuer";
            this.cbUmsatzsteuer.Size = new System.Drawing.Size(100, 21);
            this.cbUmsatzsteuer.TabIndex = 10;
            this.cbUmsatzsteuer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBezeichnung
            // 
            this.txtBezeichnung.Location = new System.Drawing.Point(125, 123);
            this.txtBezeichnung.Name = "txtBezeichnung";
            this.txtBezeichnung.Size = new System.Drawing.Size(148, 20);
            this.txtBezeichnung.TabIndex = 9;
            this.txtBezeichnung.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNettopreis
            // 
            this.txtNettopreis.Location = new System.Drawing.Point(125, 157);
            this.txtNettopreis.Name = "txtNettopreis";
            this.txtNettopreis.Size = new System.Drawing.Size(100, 20);
            this.txtNettopreis.TabIndex = 8;
            // 
            // txtArtikelID
            // 
            this.txtArtikelID.Location = new System.Drawing.Point(125, 90);
            this.txtArtikelID.Name = "txtArtikelID";
            this.txtArtikelID.ReadOnly = true;
            this.txtArtikelID.Size = new System.Drawing.Size(100, 20);
            this.txtArtikelID.TabIndex = 6;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(112, 245);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(176, 45);
            this.btnSpeichern.TabIndex = 5;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Umsatzsteuer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nettopreis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bezeichnung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ArtikelID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modus";
            // 
            // frmArtikel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmArtikel";
            this.Text = "frmArtikel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArtikel_FormClosing);
            this.Load += new System.EventHandler(this.frmArtikel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cbUmsatzsteuer;
        private System.Windows.Forms.TextBox txtBezeichnung;
        private System.Windows.Forms.TextBox txtNettopreis;
        private System.Windows.Forms.TextBox txtArtikelID;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNeuanlage;
    }
}