using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.Entity;

namespace AplikacijaZaPracenjePorudzbina
{
    public partial class frmArtikl : Form
    {
        tblArtikl modelArtikl = new tblArtikl();
        
        

        public frmArtikl()
        {
            InitializeComponent();
            PopuniDGVArtikl();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Isprazni();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (txtNaziv.Text.Trim()=="")
            {
                MessageBox.Show("Morate uneti naziv artikla!");
                return;
            }

            if (txtProizvodjac.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti naziv proizvođača!");
                return;
            }

            else
            {
                modelArtikl.naziv = txtNaziv.Text.Trim();
                modelArtikl.proizvodjac = txtProizvodjac.Text.Trim();

                using (PorudzbinaEntities1 db = new PorudzbinaEntities1())
                {
                    if (modelArtikl.artiklID == 0)//insert
                    {
                        db.tblArtikls.Add(modelArtikl);
                        db.SaveChanges();
                        MessageBox.Show("Uspešno sačuvano!");
                    }
                    else//update
                    {
                        db.Entry(modelArtikl).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Uspešno izmenjeno!");
                    }
                }
                Isprazni();
                PopuniDGVArtikl();
            }
           
        }

        void Isprazni() {
            
            txtNaziv.Text = txtProizvodjac.Text = "";
            btnSacuvaj.Text = "Sačuvaj";
            btnObrisi.Enabled = false;
            modelArtikl.artiklID = 0;

        }

        void PopuniDGVArtikl() {  

            using (PorudzbinaEntities1 db= new PorudzbinaEntities1())
            {
                dgvArtikl.DataSource = db.tblArtikls.ToList<tblArtikl>();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'porudzbinaDataSet.tblArtikl' table. You can move, or remove it, as needed.
            // this.tblArtiklTableAdapter.Fill(this.porudzbinaDataSet.tblArtikl);
            Isprazni();
            PopuniDGVArtikl();
        }

     

        private void dgvArtikl_DoubleClick(object sender, EventArgs e)
        {
            if (dgvArtikl.CurrentRow.Index != -1)
            {
                modelArtikl.artiklID = Convert.ToInt32(dgvArtikl.CurrentRow.Cells["artiklID"].Value);
                using (PorudzbinaEntities1 db = new PorudzbinaEntities1())
                {
                    modelArtikl = db.tblArtikls.Where(x => x.artiklID == modelArtikl.artiklID).FirstOrDefault();
                    txtNaziv.Text = modelArtikl.naziv;
                    txtProizvodjac.Text = modelArtikl.proizvodjac;
                }
                btnSacuvaj.Text = "Izmeni";
                btnObrisi.Enabled = true;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete artikl?","Brisanje artikla",MessageBoxButtons.YesNo)==DialogResult.Yes)
                using (PorudzbinaEntities1 db=new PorudzbinaEntities1())
                {
                    var entry = db.Entry(modelArtikl);
                    if (entry.State==EntityState.Detached)
                    {
                        db.tblArtikls.Attach(modelArtikl);
                        db.tblArtikls.Remove(modelArtikl);
                        try
                        {
                            db.SaveChanges();
                            PopuniDGVArtikl();
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

        private void btnOtkazi_Click_1(object sender, EventArgs e)
        {
            Isprazni();
        }
    }
}
