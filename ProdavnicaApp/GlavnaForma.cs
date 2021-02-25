using Microsoft.Extensions.DependencyInjection;
using ProdavnicaApp.Forme;
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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new KorisnikList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ArtikalList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new KorisnikProfil();
            frm.ShowDialog();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            if(login.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
