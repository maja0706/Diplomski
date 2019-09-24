namespace AplikacijaZaPracenjePorudzbina
{
    partial class frmDobavljac
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.dgvDobavljac = new System.Windows.Forms.DataGridView();
            this.tblDobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porudzbinaDataSet1 = new AplikacijaZaPracenjePorudzbina.PorudzbinaDataSet1();
            this.tblDobavljacTableAdapter = new AplikacijaZaPracenjePorudzbina.PorudzbinaDataSet1TableAdapters.tblDobavljacTableAdapter();
            this.dobavljacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDobavljacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbinaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(13, 22);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(69, 22);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(335, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(13, 54);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 0;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(69, 54);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(335, 20);
            this.txtAdresa.TabIndex = 2;
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(13, 89);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(44, 13);
            this.lblKontakt.TabIndex = 0;
            this.lblKontakt.Text = "Kontakt";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(69, 89);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(335, 20);
            this.txtKontakt.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(16, 172);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(16, 220);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(16, 274);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // dgvDobavljac
            // 
            this.dgvDobavljac.AllowUserToDeleteRows = false;
            this.dgvDobavljac.AutoGenerateColumns = false;
            this.dgvDobavljac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dobavljacID,
            this.nazivDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn});
            this.dgvDobavljac.DataSource = this.tblDobavljacBindingSource;
            this.dgvDobavljac.Location = new System.Drawing.Point(433, 22);
            this.dgvDobavljac.Name = "dgvDobavljac";
            this.dgvDobavljac.ReadOnly = true;
            this.dgvDobavljac.Size = new System.Drawing.Size(513, 351);
            this.dgvDobavljac.TabIndex = 3;
            this.dgvDobavljac.DoubleClick += new System.EventHandler(this.dgvDobavljac_DoubleClick);
            // 
            // tblDobavljacBindingSource
            // 
            this.tblDobavljacBindingSource.DataMember = "tblDobavljac";
            this.tblDobavljacBindingSource.DataSource = this.porudzbinaDataSet1;
            // 
            // porudzbinaDataSet1
            // 
            this.porudzbinaDataSet1.DataSetName = "PorudzbinaDataSet1";
            this.porudzbinaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDobavljacTableAdapter
            // 
            this.tblDobavljacTableAdapter.ClearBeforeFill = true;
            // 
            // dobavljacID
            // 
            this.dobavljacID.DataPropertyName = "dobavljacID";
            this.dobavljacID.HeaderText = "dobavljacID";
            this.dobavljacID.Name = "dobavljacID";
            this.dobavljacID.ReadOnly = true;
            this.dobavljacID.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmDobavljac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 538);
            this.Controls.Add(this.dgvDobavljac);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblNaziv);
            this.Name = "frmDobavljac";
            this.Text = "Dobavljač";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDobavljacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbinaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.DataGridView dgvDobavljac;
        private PorudzbinaDataSet1 porudzbinaDataSet1;
        private System.Windows.Forms.BindingSource tblDobavljacBindingSource;
        private PorudzbinaDataSet1TableAdapters.tblDobavljacTableAdapter tblDobavljacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
    }
}