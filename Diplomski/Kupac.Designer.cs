namespace AplikacijaZaPracenjePorudzbina
{
    partial class frmKupac
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
            this.components = new System.ComponentModel.Container();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.dgvKupac = new System.Windows.Forms.DataGridView();
            this.tblKupacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.porudzbinaDataSet17 = new AplikacijaZaPracenjePorudzbina.PorudzbinaDataSet17();
            this.tblKupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porudzbinaDataSet2 = new AplikacijaZaPracenjePorudzbina.PorudzbinaDataSet2();
            this.tblKupacTableAdapter = new AplikacijaZaPracenjePorudzbina.PorudzbinaDataSet2TableAdapters.tblKupacTableAdapter();
            this.cbxAdmin = new System.Windows.Forms.ComboBox();
            this.tblKupacTableAdapter1 = new AplikacijaZaPracenjePorudzbina.PorudzbinaDataSet17TableAdapters.tblKupacTableAdapter();
            this.kupacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKupacBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbinaDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKupacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbinaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(13, 27);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(93, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(318, 20);
            this.txtIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Korisničko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(92, 62);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(319, 20);
            this.txtKorisnickoIme.TabIndex = 2;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(12, 100);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(28, 13);
            this.lblSifra.TabIndex = 0;
            this.lblSifra.Text = "Šifra";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(92, 100);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(319, 20);
            this.txtSifra.TabIndex = 3;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(13, 137);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(36, 13);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(16, 208);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(16, 254);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(16, 300);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // dgvKupac
            // 
            this.dgvKupac.AllowUserToDeleteRows = false;
            this.dgvKupac.AutoGenerateColumns = false;
            this.dgvKupac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kupacID,
            this.imeDataGridViewTextBoxColumn,
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.sifraDataGridViewTextBoxColumn,
            this.adminDataGridViewTextBoxColumn});
            this.dgvKupac.DataSource = this.tblKupacBindingSource1;
            this.dgvKupac.Location = new System.Drawing.Point(448, 27);
            this.dgvKupac.Name = "dgvKupac";
            this.dgvKupac.ReadOnly = true;
            this.dgvKupac.Size = new System.Drawing.Size(507, 353);
            this.dgvKupac.TabIndex = 3;
            this.dgvKupac.DoubleClick += new System.EventHandler(this.dgvKupac_DoubleClick);
            // 
            // tblKupacBindingSource1
            // 
            this.tblKupacBindingSource1.DataMember = "tblKupac";
            this.tblKupacBindingSource1.DataSource = this.porudzbinaDataSet17;
            // 
            // porudzbinaDataSet17
            // 
            this.porudzbinaDataSet17.DataSetName = "PorudzbinaDataSet17";
            this.porudzbinaDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKupacBindingSource
            // 
            this.tblKupacBindingSource.DataMember = "tblKupac";
            this.tblKupacBindingSource.DataSource = this.porudzbinaDataSet2;
            // 
            // porudzbinaDataSet2
            // 
            this.porudzbinaDataSet2.DataSetName = "PorudzbinaDataSet2";
            this.porudzbinaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKupacTableAdapter
            // 
            this.tblKupacTableAdapter.ClearBeforeFill = true;
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.FormattingEnabled = true;
            this.cbxAdmin.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cbxAdmin.Location = new System.Drawing.Point(92, 137);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(319, 21);
            this.cbxAdmin.TabIndex = 4;
            // 
            // tblKupacTableAdapter1
            // 
            this.tblKupacTableAdapter1.ClearBeforeFill = true;
            // 
            // kupacID
            // 
            this.kupacID.DataPropertyName = "kupacID";
            this.kupacID.HeaderText = "kupacID";
            this.kupacID.Name = "kupacID";
            this.kupacID.ReadOnly = true;
            this.kupacID.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "korisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminDataGridViewTextBoxColumn
            // 
            this.adminDataGridViewTextBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewTextBoxColumn.HeaderText = "Admin";
            this.adminDataGridViewTextBoxColumn.Name = "adminDataGridViewTextBoxColumn";
            this.adminDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adminDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 404);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.dgvKupac);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIme);
            this.Name = "frmKupac";
            this.Text = "Kupac";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKupacBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbinaDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKupacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbinaDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.DataGridView dgvKupac;
        private PorudzbinaDataSet2 porudzbinaDataSet2;
        private System.Windows.Forms.BindingSource tblKupacBindingSource;
        private PorudzbinaDataSet2TableAdapters.tblKupacTableAdapter tblKupacTableAdapter;
        private System.Windows.Forms.ComboBox cbxAdmin;
        private PorudzbinaDataSet17 porudzbinaDataSet17;
        private System.Windows.Forms.BindingSource tblKupacBindingSource1;
        private PorudzbinaDataSet17TableAdapters.tblKupacTableAdapter tblKupacTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewTextBoxColumn;
    }
}