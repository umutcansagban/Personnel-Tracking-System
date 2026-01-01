namespace PersonelYonetimSistemi.Forms
{
    partial class PersonelEkleForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.lblTemelMaas = new System.Windows.Forms.Label();
            this.txtTemelMaas = new System.Windows.Forms.TextBox();
            this.lblIseGiris = new System.Windows.Forms.Label();
            this.dtpIseGiris = new System.Windows.Forms.DateTimePicker();
            this.gbPersonelTipi = new System.Windows.Forms.GroupBox();
            this.rbYariZamanli = new System.Windows.Forms.RadioButton();
            this.rbTamZamanli = new System.Windows.Forms.RadioButton();
            this.lblPrim = new System.Windows.Forms.Label();
            this.txtPrim = new System.Windows.Forms.TextBox();
            this.lblSigorta = new System.Windows.Forms.Label();
            this.txtSigorta = new System.Windows.Forms.TextBox();
            this.lblSaatlikUcret = new System.Windows.Forms.Label();
            this.txtSaatlikUcret = new System.Windows.Forms.TextBox();
            this.lblCalisilanSaat = new System.Windows.Forms.Label();
            this.txtCalisilanSaat = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();

            this.gbPersonelTipi.SuspendLayout();
            this.SuspendLayout();
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblId.Location = new System.Drawing.Point(30, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location = new System.Drawing.Point(180, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 25);
            this.txtId.TabIndex = 1;

            this.lblAd.AutoSize = true;

            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblAd.Location = new System.Drawing.Point(30, 70);

            this.lblAd.Name = "lblAd";

            this.lblAd.Size = new System.Drawing.Size(30, 19);

            this.lblAd.TabIndex = 2;

            this.lblAd.Text = "Ad:";

            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtAd.Location = new System.Drawing.Point(180, 67);

            this.txtAd.Name = "txtAd";

            this.txtAd.Size = new System.Drawing.Size(250, 25);

            this.txtAd.TabIndex = 3;

            this.lblSoyad.AutoSize = true;

            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblSoyad.Location = new System.Drawing.Point(30, 110);

            this.lblSoyad.Name = "lblSoyad";

            this.lblSoyad.Size = new System.Drawing.Size(51, 19);

            this.lblSoyad.TabIndex = 4;

            this.lblSoyad.Text = "Soyad:";

            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtSoyad.Location = new System.Drawing.Point(180, 107);

            this.txtSoyad.Name = "txtSoyad";

            this.txtSoyad.Size = new System.Drawing.Size(250, 25);

            this.txtSoyad.TabIndex = 5;

            this.lblTCKimlik.AutoSize = true;

            this.lblTCKimlik.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblTCKimlik.Location = new System.Drawing.Point(30, 150);

            this.lblTCKimlik.Name = "lblTCKimlik";

            this.lblTCKimlik.Size = new System.Drawing.Size(99, 19);

            this.lblTCKimlik.TabIndex = 6;

            this.lblTCKimlik.Text = "TC Kimlik No:";

            this.txtTCKimlik.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtTCKimlik.Location = new System.Drawing.Point(180, 147);

            this.txtTCKimlik.MaxLength = 11;

            this.txtTCKimlik.Name = "txtTCKimlik";

            this.txtTCKimlik.Size = new System.Drawing.Size(250, 25);

            this.txtTCKimlik.TabIndex = 7;

            this.lblDepartman.AutoSize = true;

            this.lblDepartman.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblDepartman.Location = new System.Drawing.Point(30, 190);

            this.lblDepartman.Name = "lblDepartman";

            this.lblDepartman.Size = new System.Drawing.Size(84, 19);

            this.lblDepartman.TabIndex = 8;

            this.lblDepartman.Text = "Departman:";

            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbDepartman.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.cmbDepartman.FormattingEnabled = true;

            this.cmbDepartman.Location = new System.Drawing.Point(180, 187);

            this.cmbDepartman.Name = "cmbDepartman";

            this.cmbDepartman.Size = new System.Drawing.Size(250, 25);

            this.cmbDepartman.TabIndex = 9;

            this.lblTemelMaas.AutoSize = true;

            this.lblTemelMaas.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblTemelMaas.Location = new System.Drawing.Point(30, 230);

            this.lblTemelMaas.Name = "lblTemelMaas";

            this.lblTemelMaas.Size = new System.Drawing.Size(88, 19);

            this.lblTemelMaas.TabIndex = 10;

            this.lblTemelMaas.Text = "Temel Maaş:";

            this.txtTemelMaas.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtTemelMaas.Location = new System.Drawing.Point(180, 227);

            this.txtTemelMaas.Name = "txtTemelMaas";

            this.txtTemelMaas.Size = new System.Drawing.Size(250, 25);

            this.txtTemelMaas.TabIndex = 11;

            this.txtTemelMaas.Text = "17002";
            this.lblIseGiris.AutoSize = true;
            this.lblIseGiris.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIseGiris.Location = new System.Drawing.Point(30, 270);
            this.lblIseGiris.Name = "lblIseGiris";
            this.lblIseGiris.Size = new System.Drawing.Size(107, 19);
            this.lblIseGiris.TabIndex = 12;
            this.lblIseGiris.Text = "İşe Giriş Tarihi:";
            this.dtpIseGiris.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpIseGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIseGiris.Location = new System.Drawing.Point(180, 267);
            this.dtpIseGiris.Name = "dtpIseGiris";
            this.dtpIseGiris.Size = new System.Drawing.Size(250, 25);
            this.dtpIseGiris.TabIndex = 13;

            this.gbPersonelTipi.Controls.Add(this.rbYariZamanli);

            this.gbPersonelTipi.Controls.Add(this.rbTamZamanli);

            this.gbPersonelTipi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.gbPersonelTipi.Location = new System.Drawing.Point(30, 310);

            this.gbPersonelTipi.Name = "gbPersonelTipi";

            this.gbPersonelTipi.Size = new System.Drawing.Size(400, 70);

            this.gbPersonelTipi.TabIndex = 14;

            this.gbPersonelTipi.TabStop = false;

            this.gbPersonelTipi.Text = "Personel Tipi";

            this.rbYariZamanli.AutoSize = true;

            this.rbYariZamanli.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.rbYariZamanli.Location = new System.Drawing.Point(230, 30);

            this.rbYariZamanli.Name = "rbYariZamanli";

            this.rbYariZamanli.Size = new System.Drawing.Size(107, 23);

            this.rbYariZamanli.TabIndex = 1;

            this.rbYariZamanli.Text = "Yarı Zamanlı";

            this.rbYariZamanli.UseVisualStyleBackColor = true;

            this.rbYariZamanli.CheckedChanged += new System.EventHandler(this.rbYariZamanli_CheckedChanged);

            this.rbTamZamanli.AutoSize = true;

            this.rbTamZamanli.Checked = true;

            this.rbTamZamanli.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.rbTamZamanli.Location = new System.Drawing.Point(50, 30);

            this.rbTamZamanli.Name = "rbTamZamanli";

            this.rbTamZamanli.Size = new System.Drawing.Size(110, 23);

            this.rbTamZamanli.TabIndex = 0;

            this.rbTamZamanli.TabStop = true;

            this.rbTamZamanli.Text = "Tam Zamanlı";

            this.rbTamZamanli.UseVisualStyleBackColor = true;

            this.rbTamZamanli.CheckedChanged += new System.EventHandler(this.rbTamZamanli_CheckedChanged);

            this.lblPrim.AutoSize = true;

            this.lblPrim.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblPrim.Location = new System.Drawing.Point(30, 400);

            this.lblPrim.Name = "lblPrim";

            this.lblPrim.Size = new System.Drawing.Size(42, 19);

            this.lblPrim.TabIndex = 15;

            this.lblPrim.Text = "Prim:";

            this.txtPrim.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtPrim.Location = new System.Drawing.Point(180, 397);

            this.txtPrim.Name = "txtPrim";

            this.txtPrim.Size = new System.Drawing.Size(250, 25);

            this.txtPrim.TabIndex = 16;

            this.txtPrim.Text = "0";

            this.lblSigorta.AutoSize = true;

            this.lblSigorta.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblSigorta.Location = new System.Drawing.Point(30, 440);

            this.lblSigorta.Name = "lblSigorta";

            this.lblSigorta.Size = new System.Drawing.Size(117, 19);

            this.lblSigorta.TabIndex = 17;

            this.lblSigorta.Text = "Sigorta Kesintisi:";

            this.txtSigorta.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtSigorta.Location = new System.Drawing.Point(180, 437);

            this.txtSigorta.Name = "txtSigorta";

            this.txtSigorta.Size = new System.Drawing.Size(250, 25);

            this.txtSigorta.TabIndex = 18;

            this.txtSigorta.Text = "0";

            this.lblSaatlikUcret.AutoSize = true;

            this.lblSaatlikUcret.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblSaatlikUcret.Location = new System.Drawing.Point(30, 400);

            this.lblSaatlikUcret.Name = "lblSaatlikUcret";

            this.lblSaatlikUcret.Size = new System.Drawing.Size(95, 19);

            this.lblSaatlikUcret.TabIndex = 19;

            this.lblSaatlikUcret.Text = "Saatlik Ücret:";

            this.lblSaatlikUcret.Visible = false;

            this.txtSaatlikUcret.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtSaatlikUcret.Location = new System.Drawing.Point(180, 397);

            this.txtSaatlikUcret.Name = "txtSaatlikUcret";

            this.txtSaatlikUcret.Size = new System.Drawing.Size(250, 25);

            this.txtSaatlikUcret.TabIndex = 20;

            this.txtSaatlikUcret.Text = "100";

            this.txtSaatlikUcret.Visible = false;

            this.lblCalisilanSaat.AutoSize = true;

            this.lblCalisilanSaat.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblCalisilanSaat.Location = new System.Drawing.Point(30, 440);

            this.lblCalisilanSaat.Name = "lblCalisilanSaat";

            this.lblCalisilanSaat.Size = new System.Drawing.Size(100, 19);

            this.lblCalisilanSaat.TabIndex = 21;

            this.lblCalisilanSaat.Text = "Çalışılan Saat:";

            this.lblCalisilanSaat.Visible = false;

            this.txtCalisilanSaat.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtCalisilanSaat.Location = new System.Drawing.Point(180, 437);

            this.txtCalisilanSaat.Name = "txtCalisilanSaat";

            this.txtCalisilanSaat.Size = new System.Drawing.Size(250, 25);

            this.txtCalisilanSaat.TabIndex = 22;

            this.txtCalisilanSaat.Text = "0";

            this.txtCalisilanSaat.Visible = false;

            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));

            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnKaydet.FlatAppearance.BorderSize = 0;

            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnKaydet.ForeColor = System.Drawing.Color.White;

            this.btnKaydet.Location = new System.Drawing.Point(180, 490);

            this.btnKaydet.Name = "btnKaydet";

            this.btnKaydet.Size = new System.Drawing.Size(120, 40);

            this.btnKaydet.TabIndex = 23;

            this.btnKaydet.Text = "💾 Kaydet";

            this.btnKaydet.UseVisualStyleBackColor = false;

            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(310, 490);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 40);
            this.btnIptal.TabIndex = 24;
            this.btnIptal.Text = "❌ İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 560);

            this.Controls.Add(this.btnIptal);

            this.Controls.Add(this.btnKaydet);

            this.Controls.Add(this.txtCalisilanSaat);

            this.Controls.Add(this.lblCalisilanSaat);

            this.Controls.Add(this.txtSaatlikUcret);

            this.Controls.Add(this.lblSaatlikUcret);

            this.Controls.Add(this.txtSigorta);

            this.Controls.Add(this.lblSigorta);

            this.Controls.Add(this.txtPrim);

            this.Controls.Add(this.lblPrim);

            this.Controls.Add(this.gbPersonelTipi);

            this.Controls.Add(this.dtpIseGiris);

            this.Controls.Add(this.lblIseGiris);

            this.Controls.Add(this.txtTemelMaas);

            this.Controls.Add(this.lblTemelMaas);

            this.Controls.Add(this.cmbDepartman);

            this.Controls.Add(this.lblDepartman);

            this.Controls.Add(this.txtTCKimlik);

            this.Controls.Add(this.lblTCKimlik);

            this.Controls.Add(this.txtSoyad);

            this.Controls.Add(this.lblSoyad);

            this.Controls.Add(this.txtAd);

            this.Controls.Add(this.lblAd);

            this.Controls.Add(this.txtId);

            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel Ekle";
            this.Load += new System.EventHandler(this.PersonelEkleForm_Load);

            this.gbPersonelTipi.ResumeLayout(false);

            this.gbPersonelTipi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.TextBox txtTCKimlik;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label lblTemelMaas;
        private System.Windows.Forms.TextBox txtTemelMaas;
        private System.Windows.Forms.Label lblIseGiris;
        private System.Windows.Forms.DateTimePicker dtpIseGiris;
        private System.Windows.Forms.GroupBox gbPersonelTipi;
        private System.Windows.Forms.RadioButton rbYariZamanli;
        private System.Windows.Forms.RadioButton rbTamZamanli;
        private System.Windows.Forms.Label lblPrim;
        private System.Windows.Forms.TextBox txtPrim;
        private System.Windows.Forms.Label lblSigorta;
        private System.Windows.Forms.TextBox txtSigorta;
        private System.Windows.Forms.Label lblSaatlikUcret;
        private System.Windows.Forms.TextBox txtSaatlikUcret;
        private System.Windows.Forms.Label lblCalisilanSaat;
        private System.Windows.Forms.TextBox txtCalisilanSaat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}