namespace AplikacijaZaPracenjePorudzbina
{
    partial class frmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.btnArtikl = new System.Windows.Forms.Button();
            this.btnDobavljac = new System.Windows.Forms.Button();
            this.btnKupac = new System.Windows.Forms.Button();
            this.btnPorudzbina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArtikl
            // 
            this.btnArtikl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnArtikl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnArtikl.Location = new System.Drawing.Point(25, 423);
            this.btnArtikl.Name = "btnArtikl";
            this.btnArtikl.Size = new System.Drawing.Size(91, 23);
            this.btnArtikl.TabIndex = 10;
            this.btnArtikl.Text = "Artikl";
            this.btnArtikl.UseVisualStyleBackColor = true;
            this.btnArtikl.Click += new System.EventHandler(this.btnArtikl_Click);
            // 
            // btnDobavljac
            // 
            this.btnDobavljac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDobavljac.Location = new System.Drawing.Point(25, 467);
            this.btnDobavljac.Name = "btnDobavljac";
            this.btnDobavljac.Size = new System.Drawing.Size(91, 23);
            this.btnDobavljac.TabIndex = 11;
            this.btnDobavljac.Text = "Dobavljač";
            this.btnDobavljac.UseVisualStyleBackColor = true;
            this.btnDobavljac.Click += new System.EventHandler(this.btnDobavljac_Click);
            // 
            // btnKupac
            // 
            this.btnKupac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKupac.Location = new System.Drawing.Point(25, 510);
            this.btnKupac.Name = "btnKupac";
            this.btnKupac.Size = new System.Drawing.Size(91, 23);
            this.btnKupac.TabIndex = 12;
            this.btnKupac.Text = "Kupac";
            this.btnKupac.UseVisualStyleBackColor = true;
            this.btnKupac.Click += new System.EventHandler(this.btnKupac_Click);
            // 
            // btnPorudzbina
            // 
            this.btnPorudzbina.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorudzbina.Location = new System.Drawing.Point(25, 553);
            this.btnPorudzbina.Name = "btnPorudzbina";
            this.btnPorudzbina.Size = new System.Drawing.Size(91, 23);
            this.btnPorudzbina.TabIndex = 13;
            this.btnPorudzbina.Text = "Porudžbina";
            this.btnPorudzbina.UseVisualStyleBackColor = true;
            this.btnPorudzbina.Click += new System.EventHandler(this.btnPorudzbina_Click);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(639, 591);
            this.Controls.Add(this.btnPorudzbina);
            this.Controls.Add(this.btnKupac);
            this.Controls.Add(this.btnDobavljac);
            this.Controls.Add(this.btnArtikl);
            this.Name = "frmGlavna";
            this.Text = "Aplikacija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArtikl;
        private System.Windows.Forms.Button btnDobavljac;
        private System.Windows.Forms.Button btnKupac;
        private System.Windows.Forms.Button btnPorudzbina;
    }
}