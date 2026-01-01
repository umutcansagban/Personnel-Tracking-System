using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using PersonelYonetimSistemi.Business;
using PersonelYonetimSistemi.Models;
using PersonelYonetimSistemi.Helpers;

namespace PersonelYonetimSistemi.Forms
{
    public partial class MainForm : Form
    {

        private PersonelYoneticisi yonetici;
        private Button selectedButton = null;

        public MainForm()
        {
            InitializeComponent();
            yonetici = PersonelYoneticisi.Instance;
            //OrnekVerileriEkle();
            TumPersoneliListele();
            IstatistikleriGuncelle();
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            ButonSecildi(btnPersonelEkle);
            
            PersonelEkleForm form = new PersonelEkleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                TumPersoneliListele();
                IstatistikleriGuncelle();
                MessageBox.Show(Sabitler.PersonelEklendi, Sabitler.BasariBaslik, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnTumPersonel_Click(object sender, EventArgs e)
        {
            ButonSecildi(btnTumPersonel);
            TumPersoneliListele();
        }
        private void btnDepartmanFiltre_Click(object sender, EventArgs e)
        {
            ButonSecildi(btnDepartmanFiltre);
            using (Form departmanForm = new Form())
            {
                departmanForm.Text = "Departman Seçin";
                departmanForm.Size = new Size(300, 200);
                departmanForm.StartPosition = FormStartPosition.CenterParent;
                departmanForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                departmanForm.MaximizeBox = false;
                departmanForm.MinimizeBox = false;

                ComboBox cmbDepartman = new ComboBox();
                cmbDepartman.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbDepartman.DataSource = Enum.GetValues(typeof(Departman));
                cmbDepartman.Location = new Point(50, 50);
                cmbDepartman.Size = new Size(200, 25);

                Button btnTamam = new Button();
                btnTamam.Text = "Filtrele";
                btnTamam.DialogResult = DialogResult.OK;
                btnTamam.Location = new Point(100, 100);
                btnTamam.Size = new Size(100, 30);

                departmanForm.Controls.Add(cmbDepartman);
                departmanForm.Controls.Add(btnTamam);

                if (departmanForm.ShowDialog() == DialogResult.OK)
                {
                    Departman seciliDepartman = (Departman)cmbDepartman.SelectedItem;
                    var personeller = yonetici.DepartmanaGoreFiltrele(seciliDepartman);
                    PersonelListesiniGoster(personeller);
                    lblDurum.Text = $"{seciliDepartman} departmanında {personeller.Count} personel bulundu.";
                }
            }
        }
        private void btnEnYuksekMaas_Click(object sender, EventArgs e)
        {
            ButonSecildi(btnEnYuksekMaas);
            
            var personeller = yonetici.EnYuksekMaasRaporu(10);
            PersonelListesiniGoster(personeller);
            lblDurum.Text = $"En yüksek maaşlı {personeller.Count} personel gösteriliyor.";
        }
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            ButonSecildi(btnRaporlar);
            
            RaporForm raporForm = new RaporForm();
            raporForm.ShowDialog();
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir personel seçin!", Sabitler.UyariBaslik,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Personel seciliPersonel = (Personel)dataGridView.SelectedRows[0].Tag;
            
            PersonelEkleForm form = new PersonelEkleForm(seciliPersonel);
            if (form.ShowDialog() == DialogResult.OK)
            {
                TumPersoneliListele();
                IstatistikleriGuncelle();
                MessageBox.Show(Sabitler.PersonelGuncellendi, Sabitler.BasariBaslik,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir personel seçin!", Sabitler.UyariBaslik,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Personel seciliPersonel = (Personel)dataGridView.SelectedRows[0].Tag;
            
            DialogResult sonuc = MessageBox.Show(
                $"{seciliPersonel.TamAd} isimli personeli silmek istediğinizden emin misiniz?",
                "Personel Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    yonetici.PersonelSil(seciliPersonel.Id);
                    TumPersoneliListele();
                    IstatistikleriGuncelle();
                    MessageBox.Show(Sabitler.PersonelSilindi, Sabitler.BasariBaslik,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", Sabitler.HataBaslik,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(aramaMetni))
            {
                TumPersoneliListele();
                return;
            }

            var personeller = yonetici.IsmeGoreAra(aramaMetni);
            PersonelListesiniGoster(personeller);
            lblDurum.Text = $"'{aramaMetni}' için {personeller.Count} sonuç bulundu.";
        }
        private void TumPersoneliListele()
        {
            var personeller = yonetici.TumPersoneliListele();
            PersonelListesiniGoster(personeller);
            lblDurum.Text = $"Toplam {personeller.Count} personel gösteriliyor.";
        }
        private void PersonelListesiniGoster(System.Collections.Generic.List<Personel> personeller)
        {
            dataGridView.Rows.Clear();

            foreach (var personel in personeller)
            {
                int rowIndex = dataGridView.Rows.Add(
                    personel.Id,
                    personel.TamAd,
                    personel.TCKimlikNo,
                    personel.Departman,
                    personel is TamZamanliPersonel ? "Tam Zamanlı" : "Yarı Zamanlı",
                    personel.TemelMaas.ToString("C2"),
                    personel.MaasHesapla().ToString("C2"),
                    personel.IseGirisTarihi.ToString("dd.MM.yyyy"),
                    personel.CalismaSuresi + " yıl"
                );
                dataGridView.Rows[rowIndex].Tag = personel;
                if (personel is TamZamanliPersonel)
                {
                    dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                }
                else
                {
                    dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 240);
                }
            }
        }
        private void IstatistikleriGuncelle()
        {
            var istatistik = yonetici.GenelIstatistikRaporu();
            
            lblToplamPersonel.Text = $"Toplam Personel: {istatistik.ToplamPersonel}";
            lblToplamMaas.Text = $"Toplam Maaş: {istatistik.ToplamMaasMaliyeti:C2}";
            lblOrtalamaMaas.Text = $"Ortalama Maaş: {(istatistik.ToplamPersonel > 0 ? istatistik.OrtalamaMaas : 0):C2}";
        }
        private void ButonSecildi(Button button)
        {
            if (selectedButton != null)
            {
                selectedButton.BackColor = ColorTranslator.FromHtml(Sabitler.SecondaryColor);
            }
            button.BackColor = ColorTranslator.FromHtml(Sabitler.AccentColor);
            selectedButton = button;
        }
        /*private void OrnekVerileriEkle()
        {
            if (PersonelDataManager.DosyaMevcutMu())
            {
                return;
            }

            try
            {
                yonetici.PersonelEkle(new TamZamanliPersonel(
                    0, "Ahmet", "Yılmaz", "12345678901",
                    Departman.BilgiTeknolojileri, 25000, DateTime.Now.AddYears(-3),
                    5000, 3500));

                yonetici.PersonelEkle(new TamZamanliPersonel(
                    0, "Ayşe", "Demir", "98765432109",
                    Departman.InsanKaynaklari, 22000, DateTime.Now.AddYears(-2),
                    3000, 3080));

                yonetici.PersonelEkle(new TamZamanliPersonel(
                    0, "Mehmet", "Kaya", "11122233344",
                    Departman.Muhasebe, 28000, DateTime.Now.AddYears(-5),
                    6000, 3920));
                yonetici.PersonelEkle(new YariZamanliPersonel(
                    0, "Fatma", "Şahin", "55566677788",
                    Departman.Pazarlama, 17002, DateTime.Now.AddYears(-1),
                    150, 80));

                yonetici.PersonelEkle(new YariZamanliPersonel(
                    0, "Ali", "Çelik", "99988877766",
                    Departman.Uretim, 17002, DateTime.Now.AddMonths(-6),
                    120, 100));
            }
            catch
            {
            }
        }*/

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void txtArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAra_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}