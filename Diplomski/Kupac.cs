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
    public partial class frmKupac : Form
    {
        tblKupac modelKupac = new tblKupac();
        public frmKupac()
        {
            InitializeComponent();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Isprazni();
        }

        void Isprazni() {
            txtIme.Text = txtKorisnickoIme.Text = txtSifra.Text = cbxAdmin.Text = "";
            btnSacuvaj.Text = "Sačuvaj";
            btnObrisi.Enabled = false;
            modelKupac.kupacID = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'porudzbinaDataSet17.tblKupac' table. You can move, or remove it, as needed.
            this.tblKupacTableAdapter1.Fill(this.porudzbinaDataSet17.tblKupac);
            // TODO: This line of code loads data into the 'porudzbinaDataSet2.tblKupac' table. You can move, or remove it, as needed.
            this.tblKupacTableAdapter.Fill(this.porudzbinaDataSet2.tblKupac);
            Isprazni();
            PopuniDGVKupac();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtIme.Text.Trim()=="")
            {
                MessageBox.Show("Morate uneti ime kupca!");
                return;
            }
            if (txtKorisnickoIme.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti korisničko ime!");
                return;
            }
            if (txtSifra.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti šifru!");
                return;
            }
            if (cbxAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti status kupca!");
                return;
            }

            else
            {
                modelKupac.ime = txtIme.Text.Trim();
                modelKupac.korisnickoIme = txtKorisnickoIme.Text.Trim();
                modelKupac.sifra = txtSifra.Text.Trim();
                modelKupac.admin = (cbxAdmin.Text == "Da");
                using (PorudzbinaEntities1 db = new PorudzbinaEntities1())
                {
                    if (modelKupac.kupacID == 0)
                    {
                        db.tblKupacs.Add(modelKupac);
                        db.SaveChanges();
                        MessageBox.Show("Uspešno sačuvano!");
                    }
                    else
                    {
                        db.Entry(modelKupac).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Uspešno izmenjeno!");
                    }

                }
                Isprazni();
                PopuniDGVKupac();
            } 
        }

        void PopuniDGVKupac()
        {
            using (PorudzbinaEntities1 db=new PorudzbinaEntities1())
            {
                dgvKupac.DataSource = db.tblKupacs.ToList<tblKupac>();

            }
        }

        private void dgvKupac_DoubleClick(object sender, EventArgs e)
        {
            if (dgvKupac.CurrentRow.Index!=-1)
            {
                modelKupac.kupacID = Convert.ToInt32(dgvKupac.CurrentRow.Cells["kupacID"].Value);
                using (PorudzbinaEntities1 db=new PorudzbinaEntities1())
                {
                    modelKupac = db.tblKupacs.Where(x => x.kupacID == modelKupac.kupacID).FirstOrDefault();
                    txtIme.Text = modelKupac.ime;
                    txtKorisnickoIme.Text = modelKupac.korisnickoIme;
                    txtSifra.Text = modelKupac.sifra;
                    if (modelKupac.admin!=null && modelKupac.admin == true)
                    {
                        cbxAdmin.Text = "Da";
                    }
                    else
                    {
                        cbxAdmin.Text = "Ne";
                    }
                    
                }
                btnSacuvaj.Text = "Izmeni";
                btnObrisi.Enabled = true;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete kupca?","Brisanje kupca",MessageBoxButtons.YesNo)==DialogResult.Yes)
                using (PorudzbinaEntities1 db=new PorudzbinaEntities1())
                {
                    var entry = db.Entry(modelKupac);
                    if (entry.State==EntityState.Detached)
                    {
                        db.tblKupacs.Attach(modelKupac);
                        db.tblKupacs.Remove(modelKupac);
                        db.SaveChanges();
                        PopuniDGVKupac();
                        Isprazni();
                        MessageBox.Show("Uspešno obrisan!");
                    }
                }
            
        }
    }
}
