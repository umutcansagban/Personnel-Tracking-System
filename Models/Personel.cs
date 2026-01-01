using System;
using PersonelYonetimSistemi.Interfaces;

namespace PersonelYonetimSistemi.Models
{
    /// <summary>
    /// Personel s�n�f�
    /// </summary>
    public abstract class Personel : IMaasHesaplanabilir, IRaporlanabilir
    {
        private static int _toplamPersonelSayisi = 0;

        public static int ToplamPersonelSayisi
        {
            get { return _toplamPersonelSayisi; }
        }

        private int _id;
        private string _ad;
        private string _soyad;
        private string _tcKimlikNo;
        private Departman _departman;
        private decimal _temelMaas;
        private DateTime _iseGirisTarihi;

        /// <summary>
        ///  property
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        ///  property
        /// </summary>
        public string Ad
        {
            get { return _ad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Ad boş olamaz!");
                }
                _ad = value.Trim();
            }
        }

        /// <summary>
        ///  property
        /// </summary>
        public string Soyad
        {
            get { return _soyad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Soyad boş olamaz!");
                }
                _soyad = value.Trim();
            }
        }

        /// <summary>
        ///  property
        /// </summary>
        public string TCKimlikNo
        {
            get { return _tcKimlikNo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 11)
                {
                    throw new ArgumentException("TC Kimlik No 11 haneli olmalıdır!");
                }
                
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new ArgumentException("TC Kimlik No sadece rakam içermelidir!");
                    }
                }
                
                _tcKimlikNo = value;
            }
        }

        /// <summary>
        ///  property
        /// </summary>
        public Departman Departman
        {
            get { return _departman; }
            set { _departman = value; }
        }

        /// <summary>
        ///  property
        /// </summary>
        public decimal TemelMaas
        {
            get { return _temelMaas; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Maa� negatif olamaz!");
                }
                if (value < 17002)
                {
                    throw new ArgumentException("Maa� asgari �cretten d���k olamaz! (Minimum: 17002 TL)");
                }
                _temelMaas = value;
            }
        }

        /// <summary>
        ///  property
        /// </summary>
        public DateTime IseGirisTarihi
        {
            get { return _iseGirisTarihi; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("��e giri� tarihi gelecek bir tarih olamaz!");
                }
                _iseGirisTarihi = value;
            }
        }

        /// <summary>
        ///  property
        /// </summary>
        public string TamAd
        {
            get { return $"{Ad} {Soyad}"; }
        }

        /// <summary>
        ///  property
        /// </summary>
        public int CalismaSuresi
        {
            get
            {
                TimeSpan fark = DateTime.Now - IseGirisTarihi;
                return (int)(fark.TotalDays / 365);
            }
        }

        protected Personel(int id, string ad, string soyad, string tcKimlikNo, 
                          Departman departman, decimal temelMaas, DateTime iseGirisTarihi)
        {
            this.Id = id;
            this.Ad = ad;
            this.Soyad = soyad;
            this.TCKimlikNo = tcKimlikNo;
            this.Departman = departman;
            this.TemelMaas = temelMaas;
            this.IseGirisTarihi = iseGirisTarihi;

            _toplamPersonelSayisi++;
        }

        /// <summary>
        /// MaasHesapla metodu
        /// </summary>
        public abstract decimal MaasHesapla();

        /// <summary>
        /// MaasDetayiGetir metodu
        /// </summary>
        public abstract string MaasDetayiGetir();

        /// <summary>
        /// RaporOlustur metodu
        /// </summary>
        public virtual string RaporOlustur()
        {
            return $"Personel Raporu\n" +
                   $"================\n" +
                   $"ID: {Id}\n" +
                   $"Ad Soyad: {TamAd}\n" +
                   $"TC Kimlik No: {TCKimlikNo}\n" +
                   $"Departman: {Departman}\n" +
                   $"Temel Maaş: {TemelMaas:C2}\n" +
                   $"İşe Giriş: {IseGirisTarihi:dd.MM.yyyy}\n" +
                   $"Çalışma Süresi: {CalismaSuresi} yıl\n" +
                   $"Toplam Maaş: {MaasHesapla():C2}\n" +
                   $"Detay: {MaasDetayiGetir()}";
        }

        /// <summary>
        /// ToString metodu
        /// </summary>
        public override string ToString()
        {
            return $"{Id} - {TamAd} ({Departman})";
        }
    }
}