
namespace ProdavnicaApp.Forme
{
    partial class KorisnikProfil
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorisničkoIme = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumRođenja = new System.Windows.Forms.DateTimePicker();
            this.btnUredi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // txtKorisničkoIme
            // 
            this.txtKorisničkoIme.Location = new System.Drawing.Point(128, 25);
            this.txtKorisničkoIme.Name = "txtKorisničkoIme";
            this.txtKorisničkoIme.Size = new System.Drawing.Size(131, 20);
            this.txtKorisničkoIme.TabIndex = 1;
            this.txtKorisničkoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisničkoIme_Validating);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(128, 53);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(131, 20);
            this.txtIme.TabIndex = 3;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(128, 81);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(131, 20);
            this.txtPrezime.TabIndex = 5;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(128, 109);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(131, 20);
            this.txtLozinka.TabIndex = 7;
            this.txtLozinka.UseSystemPasswordChar = true;
            this.txtLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtLozinka_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lozinka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum rođenja:";
            // 
            // dtpDatumRođenja
            // 
            this.dtpDatumRođenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRođenja.Location = new System.Drawing.Point(128, 137);
            this.dtpDatumRođenja.Name = "dtpDatumRođenja";
            this.dtpDatumRođenja.Size = new System.Drawing.Size(131, 20);
            this.dtpDatumRođenja.TabIndex = 9;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(128, 167);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(131, 23);
            this.btnUredi.TabIndex = 10;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // KorisnikProfil
            // 
            this.AcceptButton = this.btnUredi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 204);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.dtpDatumRođenja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisničkoIme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KorisnikProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorisničkoIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumRođenja;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}