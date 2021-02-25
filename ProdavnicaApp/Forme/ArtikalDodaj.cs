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
    public partial class ArtikalDodaj : Form
    {
        private ArtikliRepository artikliRepository = new ArtikliRepository();

        public ArtikalDodaj()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var artikal = new Artikal
            {
                Naziv = txtNaziv.Text,
                Cijena = decimal.Parse(txtCijena.Text),
                KoličinaUSkladištu = decimal.Parse(txtKoličina.Text),
                MjernaJedinica = txtMjernaJedinica.Text
            };

            artikliRepository.ArtikliAdd(artikal);

            MessageBox.Show("Artikal je uspješno dodan!", "Poruka");
            Close();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if(txtNaziv.Text == "")
            {
                errorProvider1.SetError(txtNaziv, Resources.Validacija_PoljeObavezno);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtMjernaJedinica_Validating(object sender, CancelEventArgs e)
        {
            if (txtMjernaJedinica.Text == "")
            {
                errorProvider1.SetError(txtMjernaJedinica, Resources.Validacija_PoljeObavezno);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtMjernaJedinica, null);
            }
        }

        private void txtKoličina_Validating(object sender, CancelEventArgs e)
        {
            if (txtKoličina.Text == "")
            {
                errorProvider1.SetError(txtKoličina, Resources.Validacija_PoljeObavezno);
                e.Cancel = true;
            }
            else if(!decimal.TryParse(txtKoličina.Text, out decimal result))
            {
                errorProvider1.SetError(txtKoličina, Resources.Validacija_NumeričkiUnosNeispravan);
                e.Cancel = true;
            }
            else if (result < 0)
            {
                errorProvider1.SetError(txtKoličina, "Unos mora biti veći ili jednak 0!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKoličina, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (txtCijena.Text == "")
            {
                errorProvider1.SetError(txtCijena, Resources.Validacija_PoljeObavezno);
                e.Cancel = true;
            }
            else if (!decimal.TryParse(txtCijena.Text, out decimal result))
            {
                errorProvider1.SetError(txtCijena, Resources.Validacija_NumeričkiUnosNeispravan);
                e.Cancel = true;
            }
            else if (result <= 0)
            {
                errorProvider1.SetError(txtCijena, "Unos mora biti veći od 0!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }
    }
}
