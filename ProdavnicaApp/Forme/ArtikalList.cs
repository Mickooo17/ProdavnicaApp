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
    public partial class ArtikalList : Form
    {
        private ArtikliRepository artikliRepository = new ArtikliRepository();

        public ArtikalList()
        {
            InitializeComponent();

            dgvArtikli.AutoGenerateColumns = false;
        }

        private void ArtikalList_Load(object sender, EventArgs e)
        {
            UcitajTabelu();
        }

        private void UcitajTabelu()
        {
            var list = artikliRepository.ArtikliSearch(txtNazivArtikla.Text);

            dgvArtikli.DataSource = list;
        }

        private void txtNazivArtikla_TextChanged(object sender, EventArgs e)
        {
            UcitajTabelu();
        }

        private void btnDodajArtikal_Click(object sender, EventArgs e)
        {
            if (Login.PrijavljeniKorisnik.IsAdministrator == false)
            {
                MessageBox.Show("Niste administrator!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new ArtikalDodaj();
            frm.ShowDialog();

            UcitajTabelu();
        }

        private void btnUrediArtikal_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati artikal!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Login.PrijavljeniKorisnik.IsAdministrator == false)
            {
                MessageBox.Show("Niste administrator!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var artikal = dgvArtikli.SelectedRows[0].DataBoundItem as Artikal;
            var frm = new ArtikalUredi(artikal.Id);
            frm.ShowDialog();

            UcitajTabelu();
        }

        private void btnUkloniArtikal_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati artikal!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Login.PrijavljeniKorisnik.IsAdministrator == false)
            {
                MessageBox.Show("Niste administrator!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var artikal = dgvArtikli.SelectedRows[0].DataBoundItem as Artikal;
            if (MessageBox.Show("Da li ste sigurni da želite izbrisati artikal?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                artikliRepository.ArtikliDelete(artikal.Id);
                UcitajTabelu();
            }

        }
    }
}
