namespace PersonelYonetimSistemi.Forms
{
    partial class RaporForm
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
            this.panelUst = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelSol = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnEnYuksekMaas = new System.Windows.Forms.Button();
            this.btnDepartmanOzeti = new System.Windows.Forms.Button();
            this.btnGenelIstatistik = new System.Windows.Forms.Button();
            this.txtRapor = new System.Windows.Forms.RichTextBox();

            this.panelUst.SuspendLayout();

            this.panelSol.SuspendLayout();
            this.SuspendLayout();

            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.panelUst.Controls.Add(this.lblBaslik);

            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;

            this.panelUst.Location = new System.Drawing.Point(0, 0);

            this.panelUst.Name = "panelUst";

            this.panelUst.Size = new System.Drawing.Size(900, 80);

            this.panelUst.TabIndex = 0;

            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);

            this.lblBaslik.ForeColor = System.Drawing.Color.White;

            this.lblBaslik.Location = new System.Drawing.Point(0, 0);

            this.lblBaslik.Name = "lblBaslik";

            this.lblBaslik.Size = new System.Drawing.Size(900, 80);

            this.lblBaslik.TabIndex = 0;

            this.lblBaslik.Text = "📊 RAPORLAR";

            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));

            this.panelSol.Controls.Add(this.btnKapat);

            this.panelSol.Controls.Add(this.btnEnYuksekMaas);

            this.panelSol.Controls.Add(this.btnDepartmanOzeti);

            this.panelSol.Controls.Add(this.btnGenelIstatistik);

            this.panelSol.Dock = System.Windows.Forms.DockStyle.Left;

            this.panelSol.Location = new System.Drawing.Point(0, 80);

            this.panelSol.Name = "panelSol";

            this.panelSol.Size = new System.Drawing.Size(220, 520);

            this.panelSol.TabIndex = 1;

            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));

            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnKapat.FlatAppearance.BorderSize = 0;

            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnKapat.ForeColor = System.Drawing.Color.White;

            this.btnKapat.Location = new System.Drawing.Point(20, 450);

            this.btnKapat.Name = "btnKapat";

            this.btnKapat.Size = new System.Drawing.Size(180, 45);

            this.btnKapat.TabIndex = 3;

            this.btnKapat.Text = "❌ Kapat";

            this.btnKapat.UseVisualStyleBackColor = false;

            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            this.btnEnYuksekMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.btnEnYuksekMaas.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnEnYuksekMaas.FlatAppearance.BorderSize = 0;

            this.btnEnYuksekMaas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnEnYuksekMaas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.btnEnYuksekMaas.ForeColor = System.Drawing.Color.White;

            this.btnEnYuksekMaas.Location = new System.Drawing.Point(20, 170);

            this.btnEnYuksekMaas.Name = "btnEnYuksekMaas";

            this.btnEnYuksekMaas.Size = new System.Drawing.Size(180, 50);

            this.btnEnYuksekMaas.TabIndex = 2;

            this.btnEnYuksekMaas.Text = "💰 En Yüksek Maaş";

            this.btnEnYuksekMaas.UseVisualStyleBackColor = false;

            this.btnEnYuksekMaas.Click += new System.EventHandler(this.btnEnYuksekMaas_Click);

            this.btnDepartmanOzeti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));

            this.btnDepartmanOzeti.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnDepartmanOzeti.FlatAppearance.BorderSize = 0;

            this.btnDepartmanOzeti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnDepartmanOzeti.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.btnDepartmanOzeti.ForeColor = System.Drawing.Color.White;

            this.btnDepartmanOzeti.Location = new System.Drawing.Point(20, 100);

            this.btnDepartmanOzeti.Name = "btnDepartmanOzeti";

            this.btnDepartmanOzeti.Size = new System.Drawing.Size(180, 50);

            this.btnDepartmanOzeti.TabIndex = 1;

            this.btnDepartmanOzeti.Text = "🏢 Departman Özeti";

            this.btnDepartmanOzeti.UseVisualStyleBackColor = false;

            this.btnDepartmanOzeti.Click += new System.EventHandler(this.btnDepartmanOzeti_Click);
            this.btnGenelIstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGenelIstatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenelIstatistik.FlatAppearance.BorderSize = 0;
            this.btnGenelIstatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenelIstatistik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenelIstatistik.ForeColor = System.Drawing.Color.White;
            this.btnGenelIstatistik.Location = new System.Drawing.Point(20, 30);
            this.btnGenelIstatistik.Name = "btnGenelIstatistik";
            this.btnGenelIstatistik.Size = new System.Drawing.Size(180, 50);
            this.btnGenelIstatistik.TabIndex = 0;
            this.btnGenelIstatistik.Text = "📊 Genel İstatistik";
            this.btnGenelIstatistik.UseVisualStyleBackColor = false;
            this.btnGenelIstatistik.Click += new System.EventHandler(this.btnGenelIstatistik_Click);

            this.txtRapor.BackColor = System.Drawing.Color.White;

            this.txtRapor.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.txtRapor.Dock = System.Windows.Forms.DockStyle.Fill;

            this.txtRapor.Font = new System.Drawing.Font("Consolas", 10F);

            this.txtRapor.Location = new System.Drawing.Point(220, 80);

            this.txtRapor.Name = "txtRapor";

            this.txtRapor.ReadOnly = true;

            this.txtRapor.Size = new System.Drawing.Size(680, 520);

            this.txtRapor.TabIndex = 2;

            this.txtRapor.Text = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);

            this.Controls.Add(this.txtRapor);

            this.Controls.Add(this.panelSol);

            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.RaporForm_Load);

            this.panelUst.ResumeLayout(false);

            this.panelSol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelSol;
        private System.Windows.Forms.Button btnGenelIstatistik;
        private System.Windows.Forms.Button btnDepartmanOzeti;
        private System.Windows.Forms.Button btnEnYuksekMaas;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.RichTextBox txtRapor;
    }
}