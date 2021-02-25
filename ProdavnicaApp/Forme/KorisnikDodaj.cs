using ProdavnicaApp.Database;
using ProdavnicaApp.Properties;
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

namespace ProdavnicaApp.Forme
{
    public partial class KorisnikDodaj : Form
    {
        private KorisniciRepository korisniciRepository = new KorisniciRepository();

        public KorisnikDodaj()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var korisnik = new Korisnik
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                KorisničkoIme = txtKorisničkoIme.Text,
                Lozinka = txtLozinka.Text,
                DatumRođenja = dtpDatumRođenja.Value.Date,
                IsAdministrator = cbAdministrator.Checked
            };

            korisniciRepository.KorisniciAdd(korisnik);

            MessageBox.Show("Korisnik je uspješno dodan!", "Poruka");
            Close();
        }

        private void txtKorisničkoIme_Validating(object sender, CancelEventArgs e)
        {
            if(txtKorisničkoIme.Text == "")
            {
                errorProvider1.SetError(txtKorisničkoIme, Resources.Validacija_PoljeObavezno);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKorisničkoIme, null);
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text == "")
            {
                errorProvider1.SetError(txtIme, Resources.Validacija_PoljeObavezno);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrezime.Text == "")
            {
                errorProvider1.SetError(txtPrezime, Resources.Validacija_PoljeObavezno);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (txtLozinka.Text == "")
            {
                errorProvider1.SetError(txtLozinka, Resources.Validacija_PoljeObavezno);
                e.Cancel = true;
            }
            else if(txtLozinka.Text.Length < 5)
            {
                errorProvider1.SetError(txtLozinka, Resources.Validacija_LozinkaSlaba);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLozinka, null);
            }
        }
    }
}
