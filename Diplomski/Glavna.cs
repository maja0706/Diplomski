using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaPracenjePorudzbina
{
    public partial class frmGlavna : Form
    {
        private bool? admin;

        public frmGlavna()
        {
            InitializeComponent();
        }

        public frmGlavna(bool? admin)
        {
            this.admin = admin;
            InitializeComponent();
            btnKupac.Enabled = admin.Value;
        }

        private void btnArtikl_Click(object sender, EventArgs e)
        {
            frmArtikl f1 = new frmArtikl();
            f1.ShowDialog();
            
        }

        private void btnDobavljac_Click(object sender, EventArgs e)
        {
            frmDobavljac f2 = new frmDobavljac();
            f2.ShowDialog();
        }

        private void btnKupac_Click(object sender, EventArgs e)
        {
            frmKupac f3 = new frmKupac();
            f3.ShowDialog();
        }

        private void btnPorudzbina_Click(object sender, EventArgs e)
        {
            frmPorudzbina f4 = new frmPorudzbina();
            f4.ShowDialog();
        }
    }
}
