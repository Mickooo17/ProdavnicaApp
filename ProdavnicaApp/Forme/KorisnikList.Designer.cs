
namespace ProdavnicaApp.Forme
{
    partial class KorisnikList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.KorisničkoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRođenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.btnUrediKorisnika = new System.Windows.Forms.Button();
            this.btnUkloniKorisnika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(110, 21);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(148, 20);
            this.txtImePrezime.TabIndex = 1;
            this.txtImePrezime.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AllowUserToResizeRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisničkoIme,
            this.Ime,
            this.Prezime,
            this.DatumRođenja});
            this.dgvKorisnici.Location = new System.Drawing.Point(35, 59);
            this.dgvKorisnici.MultiSelect = false;
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKorisnici.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(709, 335);
            this.dgvKorisnici.TabIndex = 2;
            // 
            // KorisničkoIme
            // 
            this.KorisničkoIme.DataPropertyName = "KorisničkoIme";
            this.KorisničkoIme.HeaderText = "Korisničko ime";
            this.KorisničkoIme.Name = "KorisničkoIme";
            this.KorisničkoIme.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // DatumRođenja
            // 
            this.DatumRođenja.DataPropertyName = "DatumRođenja";
            this.DatumRođenja.HeaderText = "Datum rođenja";
            this.DatumRođenja.Name = "DatumRođenja";
            this.DatumRođenja.ReadOnly = true;
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Location = new System.Drawing.Point(634, 405);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(110, 23);
            this.btnDodajKorisnika.TabIndex = 3;
            this.btnDodajKorisnika.Text = "Dodaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // btnUrediKorisnika
            // 
            this.btnUrediKorisnika.Location = new System.Drawing.Point(516, 19);
            this.btnUrediKorisnika.Name = "btnUrediKorisnika";
            this.btnUrediKorisnika.Size = new System.Drawing.Size(110, 23);
            this.btnUrediKorisnika.TabIndex = 4;
            this.btnUrediKorisnika.Text = "Uredi korisnika";
            this.btnUrediKorisnika.UseVisualStyleBackColor = true;
            this.btnUrediKorisnika.Click += new System.EventHandler(this.btnUrediKorisnika_Click);
            // 
            // btnUkloniKorisnika
            // 
            this.btnUkloniKorisnika.Location = new System.Drawing.Point(634, 19);
            this.btnUkloniKorisnika.Name = "btnUkloniKorisnika";
            this.btnUkloniKorisnika.Size = new System.Drawing.Size(110, 23);
            this.btnUkloniKorisnika.TabIndex = 5;
            this.btnUkloniKorisnika.Text = "Ukloni korisnika";
            this.btnUkloniKorisnika.UseVisualStyleBackColor = true;
            this.btnUkloniKorisnika.Click += new System.EventHandler(this.btnUkloniKorisnika_Click);
            // 
            // KorisnikList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 469);
            this.Controls.Add(this.btnUkloniKorisnika);
            this.Controls.Add(this.btnUrediKorisnika);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KorisnikList";
            this.Text = "Lista korisnika";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KorisnikList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button btnUrediKorisnika;
        private System.Windows.Forms.Button btnUkloniKorisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisničkoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRođenja;
    }
}