using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using PersonelYonetimSistemi.Models;

namespace PersonelYonetimSistemi.Helpers
{
    public static class PersonelDataManager
    {
        private static readonly string VarsayilanKlasor = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "PersonelYonetimSistemi");

        private static readonly string VarsayilanDosya = Path.Combine(VarsayilanKlasor, "personel_data.json");

        public static void VerileriKaydet(List<Personel> personelListesi)
        {
            try
            {
                if (!Directory.Exists(VarsayilanKlasor))
                {
                    Directory.CreateDirectory(VarsayilanKlasor);
                }

                var serializer = new JavaScriptSerializer();
                serializer.MaxJsonLength = Int32.MaxValue;
                
                var dataList = new List<Dictionary<string, object>>();
                foreach (var personel in personelListesi)
                {
                    var dict = new Dictionary<string, object>
                    {
                        ["Type"] = personel.GetType().Name,
                        ["Id"] = personel.Id,
                        ["Ad"] = personel.Ad,
                        ["Soyad"] = personel.Soyad,
                        ["TCKimlikNo"] = personel.TCKimlikNo,
                        ["Departman"] = personel.Departman.ToString(),
                        ["TemelMaas"] = personel.TemelMaas,
                        ["IseGirisTarihi"] = personel.IseGirisTarihi.ToString("yyyy-MM-dd")
                    };

                    if (personel is TamZamanliPersonel tamZamanli)
                    {
                        dict["Prim"] = tamZamanli.Prim;
                        dict["SigortaKesintisi"] = tamZamanli.SigortaKesintisi;
                    }
                    else if (personel is YariZamanliPersonel yariZamanli)
                    {
                        dict["SaatlikUcret"] = yariZamanli.SaatlikUcret;
                        dict["CalisilanSaat"] = yariZamanli.CalisilanSaat;
                    }

                    dataList.Add(dict);
                }

                string json = serializer.Serialize(dataList);
                File.WriteAllText(VarsayilanDosya, json, System.Text.Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"Veriler kaydedilirken hata oluştu: {ex.Message}");
            }
        }

        public static List<Personel> VerileriYukle()
        {
            try
            {
                if (!File.Exists(VarsayilanDosya))
                {
                    return new List<Personel>();
                }

                string json = File.ReadAllText(VarsayilanDosya, System.Text.Encoding.UTF8);
                
                if (string.IsNullOrWhiteSpace(json))
                {
                    return new List<Personel>();
                }

                var serializer = new JavaScriptSerializer();
                serializer.MaxJsonLength = Int32.MaxValue;
                var dataList = serializer.Deserialize<List<Dictionary<string, object>>>(json);

                var personelListesi = new List<Personel>();
                foreach (var dict in dataList)
                {
                    string type = dict["Type"].ToString();
                    int id = Convert.ToInt32(dict["Id"]);
                    string ad = dict["Ad"].ToString();
                    string soyad = dict["Soyad"].ToString();
                    string tcKimlikNo = dict["TCKimlikNo"].ToString();
                    Departman departman = (Departman)Enum.Parse(typeof(Departman), dict["Departman"].ToString());
                    decimal temelMaas = Convert.ToDecimal(dict["TemelMaas"]);
                    DateTime iseGirisTarihi = DateTime.Parse(dict["IseGirisTarihi"].ToString());

                    if (type == "TamZamanliPersonel")
                    {
                        decimal prim = Convert.ToDecimal(dict["Prim"]);
                        decimal sigortaKesintisi = Convert.ToDecimal(dict["SigortaKesintisi"]);
                        personelListesi.Add(new TamZamanliPersonel(id, ad, soyad, tcKimlikNo, departman, temelMaas, iseGirisTarihi, prim, sigortaKesintisi));
                    }
                    else if (type == "YariZamanliPersonel")
                    {
                        decimal saatlikUcret = Convert.ToDecimal(dict["SaatlikUcret"]);
                        int calisilanSaat = Convert.ToInt32(dict["CalisilanSaat"]);
                        personelListesi.Add(new YariZamanliPersonel(id, ad, soyad, tcKimlikNo, departman, temelMaas, iseGirisTarihi, saatlikUcret, calisilanSaat));
                    }
                }

                return personelListesi;
            }
            catch (Exception ex)
            {
                throw new Exception($"Veriler yüklenirken hata oluştu: {ex.Message}");
            }
        }

        public static bool DosyaMevcutMu()
        {
            return File.Exists(VarsayilanDosya);
        }

        public static string DosyaYoluGetir()
        {
            return VarsayilanDosya;
        }
    }
}
