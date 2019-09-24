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
    public partial class frmPorudzbina : Form
    {

        tblPorudzbina modelPorudzbina = new tblPorudzbina();
        tblStavkaPorudzbine modelStavka = new tblStavkaPorudzbine();
        public frmPorudzbina()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDetail.tblPorudzbina' table. You can move, or remove it, as needed.
            this.tblPorudzbinaTableAdapter2.Fill(this.masterDetail.tblPorudzbina);
            
            // TODO: This line of code loads data into the 'masterDetail.tblStavkaPorudzbine' table. You can move, or remove it, as needed.
           // this.tblStavkaPorudzbineTableAdapter1.Fill(this.masterDetail.tblStavkaPorudzbine);

            // TODO: This line of code loads data into the 'porudzbinaDataSet16.tblArtikl' table. You can move, or remove it, as needed.
            this.tblArtiklTableAdapter.Fill(this.porudzbinaDataSet16.tblArtikl);
            // TODO: This line of code loads data into the 'porudzbinaDataSet15.tblPorudzbina' table. You can move, or remove it, as needed.
            this.tblPorudzbinaTableAdapter1.Fill(this.porudzbinaDataSet15.tblPorudzbina);
            // TODO: This line of code loads data into the 'porudzbinaDataSet14.tblStavkaPorudzbine' table. You can move, or remove it, as needed.
            this.tblStavkaPorudzbineTableAdapter.Fill(this.porudzbinaDataSet14.tblStavkaPorudzbine);
            // TODO: This line of code loads data into the 'porudzbinaDataSet13.tblKupac' table. You can move, or remove it, as needed.
            this.tblKupacTableAdapter3.Fill(this.porudzbinaDataSet13.tblKupac);
            // TODO: This line of code loads data into the 'porudzbinaDataSet12.tblKupac' table. You can move, or remove it, as needed.
            this.tblKupacTableAdapter2.Fill(this.porudzbinaDataSet12.tblKupac);
            // TODO: This line of code loads data into the 'porudzbinaDataSet11.tblDobavljac' table. You can move, or remove it, as needed.
            this.tblDobavljacTableAdapter2.Fill(this.porudzbinaDataSet11.tblDobavljac);
            // TODO: This line of code loads data into the 'porudzbinaDataSet9.tblKupac' table. You can move, or remove it, as needed.
            this.tblKupacTableAdapter1.Fill(this.porudzbinaDataSet9.tblKupac);
            // TODO: This line of code loads data into the 'porudzbinaDataSet8.tblDobavljac' table. You can move, or remove it, as needed.
            this.tblDobavljacTableAdapter1.Fill(this.porudzbinaDataSet8.tblDobavljac);
            // TODO: This line of code loads data into the 'porudzbinaDataSet7.tblKupac' table. You can move, or remove it, as needed.
            this.tblKupacTableAdapter.Fill(this.porudzbinaDataSet7.tblKupac);
            // TODO: This line of code loads data into the 'porudzbinaDataSet6.tblDobavljac' table. You can move, or remove it, as needed.
            this.tblDobavljacTableAdapter.Fill(this.porudzbinaDataSet6.tblDobavljac);
            // TODO: This line of code loads data into the 'porudzbinaDataSet5.tblPorudzbina' table. You can move, or remove it, as needed.
            this.tblPorudzbinaTableAdapter.Fill(this.porudzbinaDataSet5.tblPorudzbina);
            
            Isprazni();
            IsprazniStavku();
            PopuniDGVPorudzbina();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Isprazni();
        }

        void Isprazni()
        {
            dtpDatum.Text = dtpIsporuceno.Text = txtIznos.Text=cbxPlaceno.Text=cbxDobavljacNaziv.Text=cbxKupacNaziv.Text= "";
            btnSacuvaj.Text = "Sačuvaj";
            btnObrisi.Enabled = false;
            modelPorudzbina.porudzbinaID = 0;
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (dtpDatum.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti datum porudžbine!");
                return;
            }

            if (dtpIsporuceno.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti datum isporuke!");
                return;
            }
            if (txtIznos.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti iznos!");
                return;
            }
            if (cbxPlaceno.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti status!");
                return;
            }
            if (cbxDobavljacNaziv.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti naziv dobavljača!");
                return;
            }

            if (cbxKupacNaziv.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti naziv kupca!");
                return;
            }


            else
            {
                modelPorudzbina.datum = dtpDatum.Value;
                modelPorudzbina.isporuceno = dtpIsporuceno.Value;
                try
                {
                    modelPorudzbina.iznos = Convert.ToDecimal(txtIznos.Text);

                }
                catch (Exception)
                {

                    MessageBox.Show("Morate uneti brojeve u polje iznos!");
                    return;
                
                }

                modelPorudzbina.placeno = (cbxPlaceno.Text == "Da");
                modelPorudzbina.dobavljacID = Convert.ToInt32(cbxDobavljacNaziv.SelectedValue);
                modelPorudzbina.kupacID = Convert.ToInt32(cbxKupacNaziv.SelectedValue);


                using (PorudzbinaEntities1 db = new PorudzbinaEntities1())
                {
                    if (modelPorudzbina.porudzbinaID == 0)
                    {
                        db.tblPorudzbinas.Add(modelPorudzbina);
                        db.SaveChanges();
                        MessageBox.Show("Uspešno sačuvano!");
                    }

                    else
                    {
                        db.Entry(modelPorudzbina).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Uspešno izmenjeno!");
                    }

                }
                Isprazni();
                PopuniDGVPorudzbina();
            }
            
            
        }

        void PopuniDGVPorudzbina(){

            using (PorudzbinaEntities1 db=new PorudzbinaEntities1())
            {
               dgvPorudzbina.DataSource = db.tblPorudzbinas.ToList<tblPorudzbina>();

            }
        }

        private void dgvPorudzbina_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPorudzbina.CurrentRow.Index!=-1)
            {
                modelPorudzbina.porudzbinaID = Convert.ToInt32(dgvPorudzbina.CurrentRow.Cells["porudzbinaID"].Value);
        
                using (PorudzbinaEntities1 db=new PorudzbinaEntities1())
                {

                    PopuniDGVStavkaPorudzbine();

                    modelPorudzbina = db.tblPorudzbinas.Where(x => x.porudzbinaID == modelPorudzbina.porudzbinaID).FirstOrDefault();
                    dtpDatum.Text = Convert.ToString( modelPorudzbina.datum);
                    dtpIsporuceno.Text = Convert.ToString(modelPorudzbina.isporuceno);
                    txtIznos.Text = Convert.ToString(modelPorudzbina.iznos);
                    if (modelPorudzbina.placeno.Value)
                    {
                        cbxPlaceno.Text = "Da";
                    }
                    else
                    {
                        cbxPlaceno.Text = "Ne";
                    }

                    // mora ovako jer ako je id = 1 ne menja text verovatno se ne izvrsi neki listener
                    cbxKupacNaziv.SelectedValue = -1;
                    cbxDobavljacNaziv.SelectedValue = -1;

                    cbxDobavljacNaziv.SelectedValue = modelPorudzbina.dobavljacID;
                    cbxKupacNaziv.SelectedValue = modelPorudzbina.kupacID;
                    cbxPorudzbinaID.DataSource = dgvPorudzbina.DataSource;// da osvezi cbx sa novim porudzbinama iz baze
                    cbxPorudzbinaID.SelectedValue = modelPorudzbina.porudzbinaID;
                    cbxPorudzbinaID.DropDownStyle = ComboBoxStyle.DropDownList;

                }
                btnSacuvaj.Text = "Izmeni";
                btnObrisi.Enabled = true;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete porudžbinu?","Brisanje porudžbine",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                using (PorudzbinaEntities1 db= new PorudzbinaEntities1())
                {
                    var entry = db.Entry(modelPorudzbina);
                    if (entry.State==EntityState.Detached)
                    {
                        db.tblPorudzbinas.Attach(modelPorudzbina);
                        db.tblPorudzbinas.Remove(modelPorudzbina);
                        try
                        {
                            db.SaveChanges();
                            PopuniDGVPorudzbina();
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

        private void btnOtkaziStavku_Click(object sender, EventArgs e)
        {
            IsprazniStavku();
        }

        void IsprazniStavku() {
            txtRedniBroj.Text = txtKolicina.Text = txtJedinicaMere.Text = txtCena.Text = cbxPorudzbinaID.Text = cbxArtiklNaziv.Text = "";
            btnSacuvajStavku.Text = "Sačuvaj stavku";
            btnObrisiStavku.Enabled = false;
            modelStavka.stavkaPorudzbineID = 0;
        }

        private void btnSacuvajStavku_Click(object sender, EventArgs e)
        {

            if (txtRedniBroj.Text.Trim()=="")
            {
                MessageBox.Show("Morate uneti redni broj stavke!");
                return;
            }
           
            if (txtKolicina.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti količinu!");
                return;
            }
            if (txtJedinicaMere.Text.Trim() == "" )
            {
                MessageBox.Show("Morate uneti jedinicu mere!");
                return;
            }
            if (txtCena.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti cenu!");
                return;
            }
            if (cbxArtiklNaziv.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti naziv artikla!");
                return;
            }
            else
            {
                try
                {
                    modelStavka.redniBroj = Convert.ToInt32(txtRedniBroj.Text.Trim());

                }
                catch (Exception)
                {

                    MessageBox.Show("Morate uneti brojeve u polje redni broj!");
                    return;

                }

                try
                {
                    modelStavka.kolicina = Convert.ToDecimal(txtKolicina.Text.Trim());

                }
                catch (Exception)
                {

                    MessageBox.Show("Morate uneti brojeve u polje kolicina!");
                    return;

                }
               
                modelStavka.jedinicaMere = txtJedinicaMere.Text.Trim();


                try
                {
                    modelStavka.cena = Convert.ToDecimal(txtCena.Text.Trim());

                }
                catch (Exception)
                {

                    MessageBox.Show("Morate uneti brojeve u polje cena!");
                    return;

                }
                
                modelStavka.porudzbinaID = Convert.ToInt32(cbxPorudzbinaID.SelectedValue);
                modelStavka.artiklID = Convert.ToInt32(cbxArtiklNaziv.SelectedValue);

                using (PorudzbinaEntities1 db = new PorudzbinaEntities1())
                {
                    if (modelStavka.stavkaPorudzbineID == 0)
                    {
                        db.tblStavkaPorudzbines.Add(modelStavka);
                        db.SaveChanges();
                        MessageBox.Show("Uspešno sačuvano!");
                    }
                    else
                    {
                        db.Entry(modelStavka).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Uspešno izmenjeno!");
                    }
                }
                IsprazniStavku();
                PopuniDGVStavkaPorudzbine();
            }

            
            
        }

        void PopuniDGVStavkaPorudzbine() {
            using (PorudzbinaEntities1 db=new PorudzbinaEntities1())
            {
                var query = from o in db.tblStavkaPorudzbines
                            where o.porudzbinaID == modelPorudzbina.porudzbinaID
                            select o;
                dgvStavkaPorudzbine.DataSource = query.ToList();
            }
        }

        private void dgvStavkaPorudzbine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvStavkaPorudzbine.CurrentRow.Index != -1)
            {
                modelStavka.stavkaPorudzbineID = Convert.ToInt32(dgvStavkaPorudzbine.CurrentRow.Cells["stavkaPorudzbineID"].Value);
                using (PorudzbinaEntities1 db = new PorudzbinaEntities1())
                {
                    modelStavka = db.tblStavkaPorudzbines.Where(x => x.stavkaPorudzbineID == modelStavka.stavkaPorudzbineID).FirstOrDefault();
                    txtRedniBroj.Text = Convert.ToString(modelStavka.redniBroj);
                    txtKolicina.Text = Convert.ToString(modelStavka.kolicina);
                    txtJedinicaMere.Text = modelStavka.jedinicaMere;
                    txtCena.Text = Convert.ToString(modelStavka.cena);

                    // mora ovako jer ako je id = 1 ne menja text verovatno se ne izvrsi neki listener
                    cbxPorudzbinaID.SelectedValue = -1;
                    cbxArtiklNaziv.SelectedValue = -1;
                    cbxPorudzbinaID.SelectedValue = modelStavka.porudzbinaID; 
                    cbxArtiklNaziv.SelectedValue = modelStavka.artiklID;

                }
                btnSacuvajStavku.Text = "Izmeni";
                btnObrisiStavku.Enabled = true;
                
            }
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete stavku porudžbine?", "Brisanje stavke porudžbine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (PorudzbinaEntities1 db = new PorudzbinaEntities1())
                {
                    var entry = db.Entry(modelStavka);
                    if (entry.State == EntityState.Detached)
                    {
                        db.tblStavkaPorudzbines.Attach(modelStavka);
                        db.tblStavkaPorudzbines.Remove(modelStavka);
                        try
                        {
                            db.SaveChanges();
                            PopuniDGVStavkaPorudzbine();
                            IsprazniStavku();
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
