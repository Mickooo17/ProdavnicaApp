using ProdavnicaApp.Database;
using ProdavnicaApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdavnicaApp
{
    public partial class Login : Form
    {
        private KorisniciRepository korisniciRepository = new KorisniciRepository();

        public static Korisnik PrijavljeniKorisnik { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            PrijavljeniKorisnik = korisniciRepository.KorisniciSearchByUsernameAndPassword(txtKorisnickoIme.Text, txtLozinka.Text);

            if (PrijavljeniKorisnik != null)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Korisničko podaci nisu validni!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
