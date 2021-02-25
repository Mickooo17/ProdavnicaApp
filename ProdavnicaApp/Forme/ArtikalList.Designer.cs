
namespace ProdavnicaApp.Forme
{
    partial class ArtikalList
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
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnDodajArtikal = new System.Windows.Forms.Button();
            this.btnUrediArtikal = new System.Windows.Forms.Button();
            this.btnUkloniArtikal = new System.Windows.Forms.Button();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv artikla:";
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Location = new System.Drawing.Point(110, 21);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(148, 20);
            this.txtNazivArtikla.TabIndex = 1;
            this.txtNazivArtikla.TextChanged += new System.EventHandler(this.txtNazivArtikla_TextChanged);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.AllowUserToResizeRows = false;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.MjernaJedinica,
            this.Količina,
            this.Cijena});
            this.dgvArtikli.Location = new System.Drawing.Point(35, 59);
            this.dgvArtikli.MultiSelect = false;
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            this.dgvArtikli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArtikli.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(709, 335);
            this.dgvArtikli.TabIndex = 2;
            // 
            // btnDodajArtikal
            // 
            this.btnDodajArtikal.Location = new System.Drawing.Point(634, 405);
            this.btnDodajArtikal.Name = "btnDodajArtikal";
            this.btnDodajArtikal.Size = new System.Drawing.Size(110, 23);
            this.btnDodajArtikal.TabIndex = 3;
            this.btnDodajArtikal.Text = "Dodaj artikal";
            this.btnDodajArtikal.UseVisualStyleBackColor = true;
            this.btnDodajArtikal.Click += new System.EventHandler(this.btnDodajArtikal_Click);
            // 
            // btnUrediArtikal
            // 
            this.btnUrediArtikal.Location = new System.Drawing.Point(516, 19);
            this.btnUrediArtikal.Name = "btnUrediArtikal";
            this.btnUrediArtikal.Size = new System.Drawing.Size(110, 23);
            this.btnUrediArtikal.TabIndex = 4;
            this.btnUrediArtikal.Text = "Uredi artikal";
            this.btnUrediArtikal.UseVisualStyleBackColor = true;
            this.btnUrediArtikal.Click += new System.EventHandler(this.btnUrediArtikal_Click);
            // 
            // btnUkloniArtikal
            // 
            this.btnUkloniArtikal.Location = new System.Drawing.Point(634, 19);
            this.btnUkloniArtikal.Name = "btnUkloniArtikal";
            this.btnUkloniArtikal.Size = new System.Drawing.Size(110, 23);
            this.btnUkloniArtikal.TabIndex = 5;
            this.btnUkloniArtikal.Text = "Ukloni artikal";
            this.btnUkloniArtikal.UseVisualStyleBackColor = true;
            this.btnUkloniArtikal.Click += new System.EventHandler(this.btnUkloniArtikal_Click);
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // MjernaJedinica
            // 
            this.MjernaJedinica.DataPropertyName = "MjernaJedinica";
            this.MjernaJedinica.HeaderText = "Mjerna jedinica";
            this.MjernaJedinica.Name = "MjernaJedinica";
            this.MjernaJedinica.ReadOnly = true;
            this.MjernaJedinica.Width = 125;
            // 
            // Količina
            // 
            this.Količina.DataPropertyName = "KoličinaUSkladištuTxt";
            this.Količina.HeaderText = "Količina na skladištu";
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            this.Količina.Width = 140;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "CijenaTxt";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // ArtikalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 469);
            this.Controls.Add(this.btnUkloniArtikal);
            this.Controls.Add(this.btnUrediArtikal);
            this.Controls.Add(this.btnDodajArtikal);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.txtNazivArtikla);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ArtikalList";
            this.Text = "Lista artikala";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ArtikalList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnDodajArtikal;
        private System.Windows.Forms.Button btnUrediArtikal;
        private System.Windows.Forms.Button btnUkloniArtikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}