using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaPracenjePorudzbina
{
    public partial class frmLogovanje : Form
    {
        tblKupac modelKupacLog = new tblKupac();
        
        public frmLogovanje()
        {
            InitializeComponent();
        }

        PorudzbinaEntities1 db = new PorudzbinaEntities1();

        private void btnUlogujSe_Click(object sender, EventArgs e)
        {
            foreach (var entry in db.tblKupacs)
            {
                if (entry.korisnickoIme == txtKorisnickoIme.Text && entry.sifra == txtLozinka.Text)
                {
                    MessageBox.Show("Uspešno ste se ulogovali!");
                    this.Visible = false;
                    frmGlavna f5 = new frmGlavna(entry.admin);
                    f5.ShowDialog();
                    return;

                }
 
            }

            MessageBox.Show("Uneli ste pogrešno korisničko ime ili šifru!");
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
