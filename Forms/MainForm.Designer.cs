namespace PersonelYonetimSistemi.Forms
{
    partial class MainForm
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
            this.panelSol = new System.Windows.Forms.Panel();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnEnYuksekMaas = new System.Windows.Forms.Button();
            this.btnDepartmanFiltre = new System.Windows.Forms.Button();
            this.btnTumPersonel = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelUst = new System.Windows.Forms.Panel();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.lblOrtalamaMaas = new System.Windows.Forms.Label();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.lblToplamPersonel = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTCKimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemelMaas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamMaas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIseGiris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalismaSuresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();

            this.panelSol.SuspendLayout();

            this.panelLogo.SuspendLayout();

            this.panelUst.SuspendLayout();

            this.panelAlt.SuspendLayout();

            this.panelOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelIslemler.SuspendLayout();
            this.SuspendLayout();
            // panelSol

            this.panelSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));

            this.panelSol.Controls.Add(this.btnRaporlar);

            this.panelSol.Controls.Add(this.btnEnYuksekMaas);

            this.panelSol.Controls.Add(this.btnDepartmanFiltre);

            this.panelSol.Controls.Add(this.btnTumPersonel);

            this.panelSol.Controls.Add(this.btnPersonelEkle);

            this.panelSol.Controls.Add(this.panelLogo);

            this.panelSol.Dock = System.Windows.Forms.DockStyle.Left;

            this.panelSol.Location = new System.Drawing.Point(0, 0);

            this.panelSol.Name = "panelSol";

            this.panelSol.Size = new System.Drawing.Size(250, 700);

            this.panelSol.TabIndex = 0;
            // btnRaporlar

            this.btnRaporlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.btnRaporlar.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnRaporlar.FlatAppearance.BorderSize = 0;

            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnRaporlar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnRaporlar.ForeColor = System.Drawing.Color.White;

            this.btnRaporlar.Location = new System.Drawing.Point(15, 450);

            this.btnRaporlar.Name = "btnRaporlar";

            this.btnRaporlar.Size = new System.Drawing.Size(220, 50);

            this.btnRaporlar.TabIndex = 5;

            this.btnRaporlar.Text = "📊 Raporlar";

            this.btnRaporlar.UseVisualStyleBackColor = false;

            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // btnEnYuksekMaas

            this.btnEnYuksekMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.btnEnYuksekMaas.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnEnYuksekMaas.FlatAppearance.BorderSize = 0;

            this.btnEnYuksekMaas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnEnYuksekMaas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnEnYuksekMaas.ForeColor = System.Drawing.Color.White;

            this.btnEnYuksekMaas.Location = new System.Drawing.Point(15, 380);

            this.btnEnYuksekMaas.Name = "btnEnYuksekMaas";

            this.btnEnYuksekMaas.Size = new System.Drawing.Size(220, 50);

            this.btnEnYuksekMaas.TabIndex = 4;

            this.btnEnYuksekMaas.Text = "💰 En Yüksek Maaş";

            this.btnEnYuksekMaas.UseVisualStyleBackColor = false;

            this.btnEnYuksekMaas.Click += new System.EventHandler(this.btnEnYuksekMaas_Click);
            // btnDepartmanFiltre

            this.btnDepartmanFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.btnDepartmanFiltre.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnDepartmanFiltre.FlatAppearance.BorderSize = 0;

            this.btnDepartmanFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnDepartmanFiltre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnDepartmanFiltre.ForeColor = System.Drawing.Color.White;

            this.btnDepartmanFiltre.Location = new System.Drawing.Point(15, 310);

            this.btnDepartmanFiltre.Name = "btnDepartmanFiltre";

            this.btnDepartmanFiltre.Size = new System.Drawing.Size(220, 50);

            this.btnDepartmanFiltre.TabIndex = 3;

            this.btnDepartmanFiltre.Text = "🔍 Departman Filtrele";

            this.btnDepartmanFiltre.UseVisualStyleBackColor = false;

            this.btnDepartmanFiltre.Click += new System.EventHandler(this.btnDepartmanFiltre_Click);
            // btnTumPersonel

            this.btnTumPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.btnTumPersonel.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnTumPersonel.FlatAppearance.BorderSize = 0;

            this.btnTumPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnTumPersonel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnTumPersonel.ForeColor = System.Drawing.Color.White;

            this.btnTumPersonel.Location = new System.Drawing.Point(15, 240);

            this.btnTumPersonel.Name = "btnTumPersonel";

            this.btnTumPersonel.Size = new System.Drawing.Size(220, 50);

            this.btnTumPersonel.TabIndex = 2;

            this.btnTumPersonel.Text = "👥 Tüm Personel";

            this.btnTumPersonel.UseVisualStyleBackColor = false;

            this.btnTumPersonel.Click += new System.EventHandler(this.btnTumPersonel_Click);
            // btnPersonelEkle

            this.btnPersonelEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.btnPersonelEkle.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnPersonelEkle.FlatAppearance.BorderSize = 0;

            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnPersonelEkle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnPersonelEkle.ForeColor = System.Drawing.Color.White;

            this.btnPersonelEkle.Location = new System.Drawing.Point(15, 170);

            this.btnPersonelEkle.Name = "btnPersonelEkle";

            this.btnPersonelEkle.Size = new System.Drawing.Size(220, 50);

            this.btnPersonelEkle.TabIndex = 1;

            this.btnPersonelEkle.Text = "➕ Personel Ekle";

            this.btnPersonelEkle.UseVisualStyleBackColor = false;

            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // panelLogo

            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.panelLogo.Controls.Add(this.lblBaslik);

            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;

            this.panelLogo.Location = new System.Drawing.Point(0, 0);

            this.panelLogo.Name = "panelLogo";

            this.panelLogo.Size = new System.Drawing.Size(250, 120);

            this.panelLogo.TabIndex = 0;
            // lblBaslik

            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);

            this.lblBaslik.ForeColor = System.Drawing.Color.White;

            this.lblBaslik.Location = new System.Drawing.Point(0, 0);

            this.lblBaslik.Name = "lblBaslik";

            this.lblBaslik.Size = new System.Drawing.Size(250, 120);

            this.lblBaslik.TabIndex = 0;

            this.lblBaslik.Text = "Personel ve Maaş\r\nYönetim Sistemi";

            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // panelUst

            this.panelUst.BackColor = System.Drawing.Color.White;

            this.panelUst.Controls.Add(this.btnAra);

            this.panelUst.Controls.Add(this.txtArama);

            this.panelUst.Controls.Add(this.lblArama);

            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;

            this.panelUst.Location = new System.Drawing.Point(250, 0);

            this.panelUst.Name = "panelUst";

            this.panelUst.Size = new System.Drawing.Size(950, 80);

            this.panelUst.TabIndex = 1;
            // btnAra

            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnAra.FlatAppearance.BorderSize = 0;

            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.btnAra.ForeColor = System.Drawing.Color.White;

            this.btnAra.Location = new System.Drawing.Point(550, 25);

            this.btnAra.Name = "btnAra";

            this.btnAra.Size = new System.Drawing.Size(100, 30);

            this.btnAra.TabIndex = 2;

            this.btnAra.Text = "🔍 Ara";

            this.btnAra.UseVisualStyleBackColor = false;

            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // txtArama

            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 11F);

            this.txtArama.Location = new System.Drawing.Point(200, 25);

            this.txtArama.Name = "txtArama";

            this.txtArama.Size = new System.Drawing.Size(330, 27);

            this.txtArama.TabIndex = 1;

            this.txtArama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArama_KeyPress);
            // lblArama

            this.lblArama.AutoSize = true;

            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.lblArama.Location = new System.Drawing.Point(30, 28);

            this.lblArama.Name = "lblArama";

            this.lblArama.Size = new System.Drawing.Size(150, 20);

            this.lblArama.TabIndex = 0;

            this.lblArama.Text = "Personel Ara (İsim):";
            // panelAlt

            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));

            this.panelAlt.Controls.Add(this.lblOrtalamaMaas);

            this.panelAlt.Controls.Add(this.lblToplamMaas);

            this.panelAlt.Controls.Add(this.lblToplamPersonel);

            this.panelAlt.Controls.Add(this.lblDurum);

            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;

            this.panelAlt.Location = new System.Drawing.Point(250, 640);

            this.panelAlt.Name = "panelAlt";

            this.panelAlt.Size = new System.Drawing.Size(950, 60);

            this.panelAlt.TabIndex = 2;
            // lblOrtalamaMaas

            this.lblOrtalamaMaas.AutoSize = true;

            this.lblOrtalamaMaas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblOrtalamaMaas.Location = new System.Drawing.Point(650, 20);

            this.lblOrtalamaMaas.Name = "lblOrtalamaMaas";

            this.lblOrtalamaMaas.Size = new System.Drawing.Size(150, 15);

            this.lblOrtalamaMaas.TabIndex = 3;

            this.lblOrtalamaMaas.Text = "Ortalama Maaş: 0,00 ₺";
            // lblToplamMaas

            this.lblToplamMaas.AutoSize = true;

            this.lblToplamMaas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblToplamMaas.Location = new System.Drawing.Point(450, 20);

            this.lblToplamMaas.Name = "lblToplamMaas";

            this.lblToplamMaas.Size = new System.Drawing.Size(130, 15);

            this.lblToplamMaas.TabIndex = 2;

            this.lblToplamMaas.Text = "Toplam Maaş: 0,00 ₺";
            // lblToplamPersonel

            this.lblToplamPersonel.AutoSize = true;

            this.lblToplamPersonel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblToplamPersonel.Location = new System.Drawing.Point(300, 20);

            this.lblToplamPersonel.Name = "lblToplamPersonel";

            this.lblToplamPersonel.Size = new System.Drawing.Size(120, 15);

            this.lblToplamPersonel.TabIndex = 1;

            this.lblToplamPersonel.Text = "Toplam Personel: 0";
            // lblDurum

            this.lblDurum.AutoSize = true;

            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.lblDurum.Location = new System.Drawing.Point(20, 20);

            this.lblDurum.Name = "lblDurum";

            this.lblDurum.Size = new System.Drawing.Size(42, 15);

            this.lblDurum.TabIndex = 0;

            this.lblDurum.Text = "Hazır.";
            // panelOrta

            this.panelOrta.Controls.Add(this.dataGridView);

            this.panelOrta.Controls.Add(this.panelIslemler);

            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;

            this.panelOrta.Location = new System.Drawing.Point(250, 80);

            this.panelOrta.Name = "panelOrta";

            this.panelOrta.Size = new System.Drawing.Size(950, 560);

            this.panelOrta.TabIndex = 3;
            // dataGridView

            this.dataGridView.AllowUserToAddRows = false;

            this.dataGridView.AllowUserToDeleteRows = false;

            this.dataGridView.BackgroundColor = System.Drawing.Color.White;

            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colAdSoyad,
            this.colTCKimlik,
            this.colDepartman,
            this.colTip,
            this.colTemelMaas,
            this.colToplamMaas,
            this.colIseGiris,
            this.colCalismaSuresi});

            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;

            this.dataGridView.Location = new System.Drawing.Point(0, 0);

            this.dataGridView.MultiSelect = false;

            this.dataGridView.Name = "dataGridView";

            this.dataGridView.ReadOnly = true;

            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dataGridView.Size = new System.Drawing.Size(950, 490);

            this.dataGridView.TabIndex = 0;
            // colId
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // colAdSoyad

            this.colAdSoyad.HeaderText = "Ad Soyad";

            this.colAdSoyad.Name = "colAdSoyad";

            this.colAdSoyad.ReadOnly = true;

            this.colAdSoyad.Width = 150;
            // colTCKimlik

            this.colTCKimlik.HeaderText = "TC Kimlik No";

            this.colTCKimlik.Name = "colTCKimlik";

            this.colTCKimlik.ReadOnly = true;

            this.colTCKimlik.Width = 110;
            // colDepartman

            this.colDepartman.HeaderText = "Departman";

            this.colDepartman.Name = "colDepartman";

            this.colDepartman.ReadOnly = true;

            this.colDepartman.Width = 130;
            // colTip

            this.colTip.HeaderText = "Personel Tipi";

            this.colTip.Name = "colTip";

            this.colTip.ReadOnly = true;

            this.colTip.Width = 110;
            // colTemelMaas

            this.colTemelMaas.HeaderText = "Temel Maaş";

            this.colTemelMaas.Name = "colTemelMaas";

            this.colTemelMaas.ReadOnly = true;

            this.colTemelMaas.Width = 100;
            // colToplamMaas

            this.colToplamMaas.HeaderText = "Toplam Maaş";

            this.colToplamMaas.Name = "colToplamMaas";

            this.colToplamMaas.ReadOnly = true;

            this.colToplamMaas.Width = 100;
            // colIseGiris
            this.colIseGiris.HeaderText = "İşe Giriş";
            this.colIseGiris.Name = "colIseGiris";
            this.colIseGiris.ReadOnly = true;
            this.colIseGiris.Width = 90;
            // colCalismaSuresi

            this.colCalismaSuresi.HeaderText = "Çalışma Süresi";

            this.colCalismaSuresi.Name = "colCalismaSuresi";

            this.colCalismaSuresi.ReadOnly = true;

            this.colCalismaSuresi.Width = 100;
            // panelIslemler
            this.panelIslemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelIslemler.Controls.Add(this.btnSil);
            this.panelIslemler.Controls.Add(this.btnDuzenle);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 490);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(950, 70);
            this.panelIslemler.TabIndex = 1;
            // btnSil

            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));

            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnSil.FlatAppearance.BorderSize = 0;

            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.btnSil.ForeColor = System.Drawing.Color.White;

            this.btnSil.Location = new System.Drawing.Point(200, 15);

            this.btnSil.Name = "btnSil";

            this.btnSil.Size = new System.Drawing.Size(150, 40);

            this.btnSil.TabIndex = 1;

            this.btnSil.Text = "🗑️ Sil";

            this.btnSil.UseVisualStyleBackColor = false;

            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // btnDuzenle

            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));

            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnDuzenle.FlatAppearance.BorderSize = 0;

            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.btnDuzenle.ForeColor = System.Drawing.Color.White;

            this.btnDuzenle.Location = new System.Drawing.Point(30, 15);

            this.btnDuzenle.Name = "btnDuzenle";

            this.btnDuzenle.Size = new System.Drawing.Size(150, 40);

            this.btnDuzenle.TabIndex = 0;

            this.btnDuzenle.Text = "✏️ Düzenle";

            this.btnDuzenle.UseVisualStyleBackColor = false;

            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);

            this.Controls.Add(this.panelOrta);

            this.Controls.Add(this.panelAlt);

            this.Controls.Add(this.panelUst);

            this.Controls.Add(this.panelSol);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel ve Maaş Yönetim Sistemi";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.panelSol.ResumeLayout(false);

            this.panelLogo.ResumeLayout(false);

            this.panelUst.ResumeLayout(false);

            this.panelUst.PerformLayout();

            this.panelAlt.ResumeLayout(false);

            this.panelAlt.PerformLayout();

            this.panelOrta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSol;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnTumPersonel;
        private System.Windows.Forms.Button btnDepartmanFiltre;
        private System.Windows.Forms.Button btnEnYuksekMaas;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblToplamPersonel;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Label lblOrtalamaMaas;
        private System.Windows.Forms.Panel panelOrta;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTCKimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartman;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemelMaas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamMaas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIseGiris;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalismaSuresi;
    }
}