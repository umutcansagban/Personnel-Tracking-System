using System;
using System.Drawing;
using System.Windows.Forms;
using PersonelYonetimSistemi.Business;
using PersonelYonetimSistemi.Models;
using PersonelYonetimSistemi.Helpers;

namespace PersonelYonetimSistemi.Forms
{
    public partial class PersonelEkleForm : Form
    {

        private PersonelYoneticisi yonetici;
        private Personel duzenlenecekPersonel = null;
        private bool duzenlemeModuMu = false;
        public PersonelEkleForm()
        {
            InitializeComponent();
            yonetici = PersonelYoneticisi.Instance;
            duzenlemeModuMu = false;
            this.Text = "Yeni Personel Ekle";
        }
        public PersonelEkleForm(Personel personel)
        {
            InitializeComponent();
            yonetici = PersonelYoneticisi.Instance;
            duzenlenecekPersonel = personel;
            duzenlemeModuMu = true;
            this.Text = "Personel Düzenle";
            PersonelBilgileriniDoldur();
        }

        private void PersonelEkleForm_Load(object sender, EventArgs e)
        {
            cmbDepartman.DataSource = Enum.GetValues(typeof(Departman));
            dtpIseGiris.MaxDate = DateTime.Now;
            rbTamZamanli.Checked = true;
            
            if (!duzenlemeModuMu)
            {
                txtId.Text = yonetici.SonrakiIdGetir().ToString();
            }
        }

        private void rbTamZamanli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTamZamanli.Checked)
            {
                lblPrim.Visible = true;
                txtPrim.Visible = true;
                lblSigorta.Visible = true;
                txtSigorta.Visible = true;
                lblSaatlikUcret.Visible = false;
                txtSaatlikUcret.Visible = false;
                lblCalisilanSaat.Visible = false;
                txtCalisilanSaat.Visible = false;
            }
        }

        private void rbYariZamanli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYariZamanli.Checked)
            {
                lblSaatlikUcret.Visible = true;
                txtSaatlikUcret.Visible = true;
                lblCalisilanSaat.Visible = true;
                txtCalisilanSaat.Visible = true;
                lblPrim.Visible = false;
                txtPrim.Visible = false;
                lblSigorta.Visible = false;
                txtSigorta.Visible = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormValidasyonu())
                {
                    return;
                }
                Personel yeniPersonel = PersonelOlustur();

                if (duzenlemeModuMu)
                {
                    yonetici.PersonelGuncelle(yeniPersonel);
                }
                else
                {
                    yonetici.PersonelEkle(yeniPersonel);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", Sabitler.HataBaslik,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private bool FormValidasyonu()
        {
            if (!ValidationHelper.MetinGecerliMi(txtAd.Text, 2))
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır!", Sabitler.UyariBaslik,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAd.Focus();
                return false;
            }
            if (!ValidationHelper.MetinGecerliMi(txtSoyad.Text, 2))
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır!", Sabitler.UyariBaslik,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoyad.Focus();
                return false;
            }
            if (!ValidationHelper.TCKimlikNoGecerliMi(txtTCKimlik.Text))
            {
                MessageBox.Show("TC Kimlik No 11 haneli olmalı ve sadece rakam içermelidir!", Sabitler.UyariBaslik,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTCKimlik.Focus();
                return false;
            }
            decimal temelMaas;
            if (!decimal.TryParse(txtTemelMaas.Text, out temelMaas) || temelMaas < Sabitler.MinimumMaas)
            {
                MessageBox.Show($"Temel maaş minimum {Sabitler.MinimumMaas:C2} olmalıdır!", Sabitler.UyariBaslik,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTemelMaas.Focus();
                return false;
            }
            if (rbTamZamanli.Checked)
            {
                decimal prim, sigorta;
                if (!decimal.TryParse(txtPrim.Text, out prim) || prim < 0)
                {
                    MessageBox.Show("Prim negatif olamaz!", Sabitler.UyariBaslik,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrim.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtSigorta.Text, out sigorta) || sigorta < 0)
                {
                    MessageBox.Show("Sigorta kesintisi negatif olamaz!", Sabitler.UyariBaslik,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSigorta.Focus();
                    return false;
                }
            }
            else
            {
                decimal saatlikUcret;
                int calisilanSaat;

                if (!decimal.TryParse(txtSaatlikUcret.Text, out saatlikUcret) || saatlikUcret < Sabitler.MinimumSaatlikUcret)
                {
                    MessageBox.Show($"Saatlik ücret minimum {Sabitler.MinimumSaatlikUcret:C2} olmalıdır!", Sabitler.UyariBaslik,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSaatlikUcret.Focus();
                    return false;
                }

                if (!int.TryParse(txtCalisilanSaat.Text, out calisilanSaat) || calisilanSaat < 0 || calisilanSaat > 200)
                {
                    MessageBox.Show("Çalışılan saat 0-200 arasında olmalıdır!", Sabitler.UyariBaslik,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCalisilanSaat.Focus();
                    return false;
                }
            }

            return true;
        }
        private Personel PersonelOlustur()
        {
            int id = duzenlemeModuMu ? duzenlenecekPersonel.Id : 0;
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string tcKimlik = txtTCKimlik.Text.Trim();
            Departman departman = (Departman)cmbDepartman.SelectedItem;
            decimal temelMaas = decimal.Parse(txtTemelMaas.Text);
            DateTime iseGiris = dtpIseGiris.Value;

            if (rbTamZamanli.Checked)
            {
                decimal prim = decimal.Parse(txtPrim.Text);
                decimal sigorta = decimal.Parse(txtSigorta.Text);
                
                return new TamZamanliPersonel(id, ad, soyad, tcKimlik, departman, 
                    temelMaas, iseGiris, prim, sigorta);
            }
            else
            {
                decimal saatlikUcret = decimal.Parse(txtSaatlikUcret.Text);
                int calisilanSaat = int.Parse(txtCalisilanSaat.Text);
                
                return new YariZamanliPersonel(id, ad, soyad, tcKimlik, departman, 
                    temelMaas, iseGiris, saatlikUcret, calisilanSaat);
            }
        }
        private void PersonelBilgileriniDoldur()
        {
            txtId.Text = duzenlenecekPersonel.Id.ToString();
            txtAd.Text = duzenlenecekPersonel.Ad;
            txtSoyad.Text = duzenlenecekPersonel.Soyad;
            txtTCKimlik.Text = duzenlenecekPersonel.TCKimlikNo;
            cmbDepartman.SelectedItem = duzenlenecekPersonel.Departman;
            txtTemelMaas.Text = duzenlenecekPersonel.TemelMaas.ToString();
            dtpIseGiris.Value = duzenlenecekPersonel.IseGirisTarihi;

            if (duzenlenecekPersonel is TamZamanliPersonel)
            {
                TamZamanliPersonel tamZamanli = (TamZamanliPersonel)duzenlenecekPersonel;
                rbTamZamanli.Checked = true;
                txtPrim.Text = tamZamanli.Prim.ToString();
                txtSigorta.Text = tamZamanli.SigortaKesintisi.ToString();
            }
            else if (duzenlenecekPersonel is YariZamanliPersonel)
            {
                YariZamanliPersonel yariZamanli = (YariZamanliPersonel)duzenlenecekPersonel;
                rbYariZamanli.Checked = true;
                txtSaatlikUcret.Text = yariZamanli.SaatlikUcret.ToString();
                txtCalisilanSaat.Text = yariZamanli.CalisilanSaat.ToString();
            }
        }
    }
}