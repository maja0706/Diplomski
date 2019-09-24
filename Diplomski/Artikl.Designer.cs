namespace AplikacijaZaPracenjePorudzbina
{
    partial class frmArtikl
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
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.dgvArtikl = new System.Windows.Forms.DataGridView();
            this.tblArtiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porudzbinaDataSet = new AplikacijaZaPracenjePorudzbina.PorudzbinaDataSet();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.tblArtiklTableAdapter = new AplikacijaZaPracenjePorudzbina.PorudzbinaDataSetTableAdapters.tblArtiklTableAdapter();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.artiklID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodjacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbinaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 53);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(90, 53);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(266, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(12, 79);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(62, 13);
            this.lblProizvodjac.TabIndex = 0;
            this.lblProizvodjac.Text = "Proizvodjač";
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(90, 79);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(266, 20);
            this.txtProizvodjac.TabIndex = 2;
            // 
            // dgvArtikl
            // 
            this.dgvArtikl.AllowUserToDeleteRows = false;
            this.dgvArtikl.AutoGenerateColumns = false;
            this.dgvArtikl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artiklID,
            this.nazivDataGridViewTextBoxColumn,
            this.proizvodjacDataGridViewTextBoxColumn});
            this.dgvArtikl.DataSource = this.tblArtiklBindingSource;
            this.dgvArtikl.Location = new System.Drawing.Point(376, 53);
            this.dgvArtikl.Name = "dgvArtikl";
            this.dgvArtikl.ReadOnly = true;
            this.dgvArtikl.Size = new System.Drawing.Size(424, 288);
            this.dgvArtikl.TabIndex = 2;
            this.dgvArtikl.DoubleClick += new System.EventHandler(this.dgvArtikl_DoubleClick);
            // 
            // tblArtiklBindingSource
            // 
            this.tblArtiklBindingSource.DataMember = "tblArtikl";
            this.tblArtiklBindingSource.DataSource = this.porudzbinaDataSet;
            // 
            // porudzbinaDataSet
            // 
            this.porudzbinaDataSet.DataSetName = "PorudzbinaDataSet";
            this.porudzbinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(15, 156);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(15, 199);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // tblArtiklTableAdapter
            // 
            this.tblArtiklTableAdapter.ClearBeforeFill = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(15, 244);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 4;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click_1);
            // 
            // artiklID
            // 
            this.artiklID.DataPropertyName = "artiklID";
            this.artiklID.HeaderText = "Artikl ID";
            this.artiklID.Name = "artiklID";
            this.artiklID.ReadOnly = true;
            this.artiklID.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proizvodjacDataGridViewTextBoxColumn
            // 
            this.proizvodjacDataGridViewTextBoxColumn.DataPropertyName = "proizvodjac";
            this.proizvodjacDataGridViewTextBoxColumn.HeaderText = "Proizvodjač";
            this.proizvodjacDataGridViewTextBoxColumn.Name = "proizvodjacDataGridViewTextBoxColumn";
            this.proizvodjacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(849, 528);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dgvArtikl);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.lblNaziv);
            this.Name = "frmArtikl";
            this.Text = "Artikl";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbinaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.DataGridView dgvArtikl;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisi;
        private PorudzbinaDataSet porudzbinaDataSet;
        private System.Windows.Forms.BindingSource tblArtiklBindingSource;
        private PorudzbinaDataSetTableAdapters.tblArtiklTableAdapter tblArtiklTableAdapter;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodjacDataGridViewTextBoxColumn;
    }
}

