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

namespace ProdavnicaApp.Forme
{
    public partial class KorisnikList : Form
    {
        private KorisniciRepository korisniciRepository = new KorisniciRepository();

        public KorisnikList()
        {
            InitializeComponent();

            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisnikList_Load(object sender, EventArgs e)
        {
            UcitajTabelu();
        }

        private void UcitajTabelu()
        {
            var list = korisniciRepository.KorisniciSearch(txtImePrezime.Text);

            dgvKorisnici.DataSource = list;
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajTabelu();
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            if (Login.PrijavljeniKorisnik.IsAdministrator == false)
            {
                MessageBox.Show("Niste administrator!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new KorisnikDodaj();
            frm.ShowDialog();

            UcitajTabelu();
        }

        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati korisnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Login.PrijavljeniKorisnik.IsAdministrator == false)
            {
                MessageBox.Show("Niste administrator!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            var frm = new KorisnikUredi(korisnik.Id);
            frm.ShowDialog();

            UcitajTabelu();
        }

        private void btnUkloniKorisnika_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati korisnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Login.PrijavljeniKorisnik.IsAdministrator == false)
            {
                MessageBox.Show("Niste administrator!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            if(korisnik.Id == Login.PrijavljeniKorisnik.Id)
            {
                MessageBox.Show("Ne možete izbrisati svoj korisnički račun!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Da li ste sigurni da želite izbrisati korisnika?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                korisniciRepository.KorisniciDelete(korisnik.Id);
                UcitajTabelu();
            }

        }
    }
}
