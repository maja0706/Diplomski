using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaPracenjePorudzbina
{
    
    public partial class frmDobavljac : Form
    {
        
        tblDobavljac modelDobavljac = new tblDobavljac();

        
        public frmDobavljac()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'porudzbinaDataSet1.tblDobavljac' table. You can move, or remove it, as needed.
            //this.tblDobavljacTableAdapter.Fill(this.porudzbinaDataSet1.tblDobavljac);

            Isprazni();
            PopuniDGVDobavljac();

        }


        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Isprazni();
        }

        void Isprazni()
        {

            txtNaziv.Text = txtAdresa.Text = txtKontakt.Text = "";
            btnSacuvaj.Text = "Sačuvaj";
            btnObrisi.Enabled = false;
            modelDobavljac.dobavljacID = 0;

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)

        {
            if (txtNaziv.Text.Trim()=="")
            {
                MessageBox.Show("Morate uneti naziv dobavljača");
                return;
            }

            if (txtAdresa.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti adresu dobavljača");
                return;
            }

            if (txtKontakt.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti kontakt dobavljača");
                return;
            }

            else
            {
                modelDobavljac.naziv = txtNaziv.Text.Trim();
                modelDobavljac.adresa = txtAdresa.Text.Trim();
                modelDobavljac.kontakt = txtKontakt.Text.Trim();

                using (PorudzbinaEntities1 db = new PorudzbinaEntities1())
                {
                    if (modelDobavljac.dobavljacID == 0)
                    {
                        db.tblDobavljacs.Add(modelDobavljac);
                        db.SaveChanges();
                        MessageBox.Show("Uspešno sačuvano!");

                    }
                    else
                    {
                        db.Entry(modelDobavljac).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Uspešno izmenjeno!");
                    }

                }
                Isprazni();
                PopuniDGVDobavljac();
            }   
            
        }

        void PopuniDGVDobavljac()
        {
            using (PorudzbinaEntities1 db=new PorudzbinaEntities1())
            {
                dgvDobavljac.DataSource = db.tblDobavljacs.ToList<tblDobavljac>();

            }
        }

        private void dgvDobavljac_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDobavljac.CurrentRow.Index!=-1)
            {
                modelDobavljac.dobavljacID = Convert.ToInt32(dgvDobavljac.CurrentRow.Cells["dobavljacID"].Value);
                using (PorudzbinaEntities1 db=new PorudzbinaEntities1())
                {
                    modelDobavljac = db.tblDobavljacs.Where(x => x.dobavljacID == modelDobavljac.dobavljacID).FirstOrDefault();
                    txtNaziv.Text = modelDobavljac.naziv;
                    txtAdresa.Text = modelDobavljac.adresa;
                    txtKontakt.Text = modelDobavljac.kontakt;

                }
                btnSacuvaj.Text = "Izmeni";
                btnObrisi.Enabled = true;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete dobavljača?", "Obriši dobavljača", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                using (PorudzbinaEntities1 db = new PorudzbinaEntities1())
                {
                    var entry = db.Entry(modelDobavljac);
                    if (entry.State == EntityState.Detached)
                    {
                        db.tblDobavljacs.Attach(modelDobavljac);
                        db.tblDobavljacs.Remove(modelDobavljac);
                        try
                        {
                            db.SaveChanges();
                            PopuniDGVDobavljac();
                            Isprazni();
                            MessageBox.Show("Uspešno obrisano!");
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Postoje povezani podaci!"); ;
                        }
                       


                    }

                }
        }           
        }
    }
}
