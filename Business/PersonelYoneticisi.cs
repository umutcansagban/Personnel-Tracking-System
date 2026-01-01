using System;
using System.Collections.Generic;
using System.Linq;
using PersonelYonetimSistemi.Models;
using PersonelYonetimSistemi.Helpers;

namespace PersonelYonetimSistemi.Business
{
    /// <summary>
    /// PersonelYoneticisi s�n�f�
    /// </summary>
        /// <summary>
        ///  property
        /// </summary>
    public class PersonelYoneticisi
    {
        private static PersonelYoneticisi _instance;
        private static readonly object _lock = new object();

        public static PersonelYoneticisi Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PersonelYoneticisi();
                        }
                    }
                }
                return _instance;
            }
        }

        private List<Personel> _personelListesi;
        private int _sonId;

        private PersonelYoneticisi()
        {
            _personelListesi = new List<Personel>();            _sonId = 0;
            VerileriYukle();
        }
        

        /// <summary>
        /// PersonelEkle metodu
        /// </summary>
        public bool PersonelEkle(Personel personel)
        {
            try
            {
                if (TCKimlikNoMevcutMu(personel.TCKimlikNo))
                {
                    throw new InvalidOperationException(Sabitler.TCKimlikMevcut);
                }

                _sonId++;
                personel.Id = _sonId;

                _personelListesi.Add(personel);

                VerileriKaydet();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// PersonelGuncelle metodu
        /// </summary>
        public bool PersonelGuncelle(Personel personel)
        {
            try
            {
                var mevcutPersonel = PersonelGetir(personel.Id);
                if (mevcutPersonel == null)
                {
                    throw new InvalidOperationException(Sabitler.PersonelBulunamadi);
                }

                if (mevcutPersonel.TCKimlikNo != personel.TCKimlikNo)
                {
                    if (TCKimlikNoMevcutMu(personel.TCKimlikNo))
                    {
                        throw new InvalidOperationException(Sabitler.TCKimlikMevcut);
                    }
                }

                _personelListesi.Remove(mevcutPersonel);
                _personelListesi.Add(personel);

                VerileriKaydet();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// PersonelSil metodu
        /// </summary>
        public bool PersonelSil(int id)
        {
            try
            {
                var personel = PersonelGetir(id);
                if (personel == null)
                {
                    throw new InvalidOperationException(Sabitler.PersonelBulunamadi);
                }

                _personelListesi.Remove(personel);
                VerileriKaydet();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// PersonelGetir metodu
        /// </summary>
        public Personel PersonelGetir(int id)
        {
            return _personelListesi.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// TumPersoneliListele metodu
        /// </summary>
        public List<Personel> TumPersoneliListele()
        {
            return new List<Personel>(_personelListesi);
        }

        /// <summary>
        /// DepartmanaGoreFiltrele metodu
        /// </summary>
        public List<Personel> DepartmanaGoreFiltrele(Departman departman)
        {
            return _personelListesi.Where(p => p.Departman == departman).ToList();
        }

        /// <summary>
        /// MaasAraliginaGoreFiltrele metodu
        /// </summary>
        public List<Personel> MaasAraliginaGoreFiltrele(decimal minMaas, decimal maxMaas)
        {
            return _personelListesi.Where(p => p.MaasHesapla() >= minMaas && p.MaasHesapla() <= maxMaas).ToList();
        }

        /// <summary>
        /// IsmeGoreAra metodu
        /// </summary>
        public List<Personel> IsmeGoreAra(string isim)
        {
            string aramaMetni = isim.ToLower().Trim();
            return _personelListesi.Where(p =>
                p.Ad.ToLower().Contains(aramaMetni) ||
                p.Soyad.ToLower().Contains(aramaMetni) ||
                p.TamAd.ToLower().Contains(aramaMetni)
            ).ToList();
        }

        /// <summary>
        /// TCKimlikNoIleAra metodu
        /// </summary>
        public Personel TCKimlikNoIleAra(string tcKimlikNo)
        {
            return _personelListesi.FirstOrDefault(p => p.TCKimlikNo == tcKimlikNo);
        }

        /// <summary>
        /// TipineGoreFiltrele metodu
        /// </summary>
        public List<Personel> TipineGoreFiltrele(bool tamZamanli)
        {
            if (tamZamanli)
            {
                return _personelListesi.Where(p => p is TamZamanliPersonel).ToList();
            }
            else
            {
                return _personelListesi.Where(p => p is YariZamanliPersonel).ToList();
            }
        }

        /// <summary>
        /// EnYuksekMaasRaporu metodu
        /// </summary>
        public List<Personel> EnYuksekMaasRaporu(int adet = 10)
        {
            return _personelListesi
                .OrderByDescending(p => p.MaasHesapla())
                .Take(adet)
                .ToList();
        }

        /// <summary>
        /// DepartmanOzetiRaporu metodu
        /// </summary>
        public Dictionary<Departman, DepartmanOzet> DepartmanOzetiRaporu()
        {
            var sonuc = new Dictionary<Departman, DepartmanOzet>();

            foreach (Departman dept in Enum.GetValues(typeof(Departman)))
            {
                var departmanPersonelleri = DepartmanaGoreFiltrele(dept);

                if (departmanPersonelleri.Count > 0)
                {
                    var ozet = new DepartmanOzet
                    {
                        Departman = dept,
                        PersonelSayisi = departmanPersonelleri.Count,
                        ToplamMaas = departmanPersonelleri.Sum(p => p.MaasHesapla()),
                        OrtalamaMaas = departmanPersonelleri.Average(p => p.MaasHesapla()),
                        EnYuksekMaas = departmanPersonelleri.Max(p => p.MaasHesapla()),
                        EnDusukMaas = departmanPersonelleri.Min(p => p.MaasHesapla())
                    };

                    sonuc.Add(dept, ozet);
                }
            }

            return sonuc;
        }

        /// <summary>
        /// ToplamMaasRaporu metodu
        /// </summary>
        public decimal ToplamMaasRaporu()
        {
            return _personelListesi.Sum(p => p.MaasHesapla());
        }

        /// <summary>
        /// GenelIstatistikRaporu metodu
        /// </summary>
        public GenelIstatistik GenelIstatistikRaporu()
        {
            if (_personelListesi.Count == 0)
            {
                return new GenelIstatistik();
            }

            return new GenelIstatistik
            {
                ToplamPersonel = _personelListesi.Count,
                TamZamanliSayisi = _personelListesi.Count(p => p is TamZamanliPersonel),
                YariZamanliSayisi = _personelListesi.Count(p => p is YariZamanliPersonel),
                ToplamMaasMaliyeti = ToplamMaasRaporu(),
                OrtalamaMaas = _personelListesi.Average(p => p.MaasHesapla()),
                EnYuksekMaas = _personelListesi.Max(p => p.MaasHesapla()),
                EnDusukMaas = _personelListesi.Min(p => p.MaasHesapla())
            };
        }

        private bool TCKimlikNoMevcutMu(string tcKimlikNo)
        {
            return _personelListesi.Any(p => p.TCKimlikNo == tcKimlikNo);
        }

        /// <summary>
        /// SonrakiIdGetir metodu
        /// </summary>
        public int SonrakiIdGetir()
        {
            return _sonId + 1;
        }

        /// <summary>
        /// TumunuTemizle metodu
        /// </summary>
        public void TumunuTemizle()
        {
            _personelListesi.Clear();
            _sonId = 0;
        }

        public void VerileriKaydet()
        {
            try
            {
                PersonelDataManager.VerileriKaydet(_personelListesi);
            }
            catch (Exception ex)
            {
                throw new Exception($"Veriler kaydedilirken hata: {ex.Message}");
            }
        }

        public void VerileriYukle()
        {
            try
            {
                if (PersonelDataManager.DosyaMevcutMu())
                {
                    var yuklenenListe = PersonelDataManager.VerileriYukle();
                    if (yuklenenListe != null && yuklenenListe.Count > 0)
                    {
                        _personelListesi = yuklenenListe;
                        _sonId = _personelListesi.Max(p => p.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Veriler yüklenirken hata: {ex.Message}");
            }
        }
    }
}

    /// <summary>
    /// DepartmanOzet s�n�f�
    /// </summary>
        /// <summary>
        ///  property
        /// </summary>
    public class DepartmanOzet
    {
        public Departman Departman { get; set; }
        public int PersonelSayisi { get; set; }
        public decimal ToplamMaas { get; set; }
        public decimal OrtalamaMaas { get; set; }
        public decimal EnYuksekMaas { get; set; }
        public decimal EnDusukMaas { get; set; }

        /// <summary>
        /// ToString metodu
        /// </summary>
        public override string ToString()
        {
            return $"{Departman}: {PersonelSayisi} personel, Toplam: {ToplamMaas:C2}, Ortalama: {OrtalamaMaas:C2}";
        }
    }

    /// <summary>
    /// GenelIstatistik s�n�f�
    /// </summary>
        /// <summary>
        ///  property
        /// </summary>
    public class GenelIstatistik
    {
        public int ToplamPersonel { get; set; }
        public int TamZamanliSayisi { get; set; }
        public int YariZamanliSayisi { get; set; }
        public decimal ToplamMaasMaliyeti { get; set; }
        public decimal OrtalamaMaas { get; set; }
        public decimal EnYuksekMaas { get; set; }
        public decimal EnDusukMaas { get; set; }
    }