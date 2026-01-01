# Personel ve Maaş Yönetim Sistemi

Modern, nesne yönelimli programlama prensipleriyle geliştirilmiş personel ve maaş yönetim uygulaması.

## 📋 Özellikler

### Nesne Yönelimli Programlama (OOP) Özellikleri
- ✅ **Abstract Class**: `Personel` sınıfı (örneklenemez temel sınıf)
- ✅ **Inheritance**: `TamZamanliPersonel` ve `YariZamanliPersonel` türetilmiş sınıfları
- ✅ **Interface**: `IMaasHesaplanabilir` ve `IRaporlanabilir` arayüzleri
- ✅ **Encapsulation**: Tüm alanlar private, kontrollü erişim ile public property'ler
- ✅ **Validation**: 3+ doğrulama kuralı (boş olamaz, negatif olamaz, TC Kimlik kontrolü, vb.)
- ✅ **Static Members**: Personel sayacı, sabitler, singleton pattern
- ✅ **Constructor Overloading**: Aşırı yüklenmiş kurucular
- ✅ **this/base Kullanımı**: Kurucularda this ve base anahtar kelimeleri

### Uygulama Özellikleri
- ➕ **Personel Ekleme**: Tam zamanlı ve yarı zamanlı personel ekleme
- 📋 **Listeleme**: Tüm personel, departmana göre, personel tipine göre
- 🔍 **Arama/Filtreleme**: İsme göre arama, departman filtresi, maaş aralığı filtresi
- ✏️ **Güncelleme**: Personel bilgilerini düzenleme
- 🗑️ **Silme**: Personel silme
- 📊 **Raporlama**: 
  - Genel istatistik raporu
  - Departman özet raporu
  - En yüksek maaş raporu
- ⚠️ **Hata Yönetimi**: Geçersiz veri girişi, duplicate TC Kimlik, bulunamayan kayıt kontrolü

### Modern Tasarım
- 🎨 Gradient renkli arka planlar
- 🖼️ İkonlu butonlar (➕ 🔍 📊 💰 vb.)
- ✨ Animasyonlu giriş ekranı (splash screen)
- 🎯 Hover efektleri
- 📱 Temiz ve kullanıcı dostu arayüz

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler
- Visual Studio 2022 (veya daha yeni)
- .NET Framework 4.8

### Adımlar

1. **Projeyi Açın**
   - `PersonelYonetimSistemi.sln` dosyasını Visual Studio 2022'de açın

2. **Projeyi Derleyin**
   - `Build` > `Build Solution` (veya `Ctrl+Shift+B`)

3. **Çalıştırın**
   - `Debug` > `Start Debugging` (veya `F5`)

## 🖼️ Logo Değiştirme

Kendi logonuzu eklemek için:

1. **Logo Hazırlayın**
   - PNG formatında, transparan arka planlı
   - Önerilen boyut: 150x150 piksel veya daha büyük (kare)

2. **Logo Dosyasını Ekleyin**
   - Logonuzu projenin ana dizinine kopyalayın
   - Dosya adı: `logo.png` (veya istediğiniz bir isim)

3. **Visual Studio'da Ekleyin**
   - Solution Explorer'da projeye sağ tıklayın
   - `Add` > `Existing Item` seçin
   - Logo dosyanızı seçin
   - Logo dosyasına sağ tıklayın > `Properties`
   - `Build Action` özelliğini `Embedded Resource` yapın

4. **Kodu Güncelleyin**
   - `Forms\SplashForm.Designer.cs` dosyasını açın
   - `pictureBoxLogo` bölümünü bulun (yaklaşık satır 35)
   - Aşağıdaki satırı ekleyin:
   ```csharp
   this.pictureBoxLogo.Image = System.Drawing.Image.FromFile("logo.png");
   ```
   
   VEYA embedded resource olarak eklediyseniz:
   ```csharp
   this.pictureBoxLogo.Image = Properties.Resources.logo;
   ```

5. **Alternatif Yöntem (Daha Kolay)**
   - Visual Studio'da `Forms\SplashForm.cs` dosyasını açın
   - Designer görünümüne geçin (sağ tıklayın > `View Designer`)
   - `pictureBoxLogo` kontrolüne tıklayın
   - Properties penceresinde `Image` özelliğini bulun
   - `...` butonuna tıklayın
   - `Local Resource` > `Import` ile logonuzu seçin

## 📁 Proje Yapısı

```
PersonelYonetimSistemi/
├── Models/                 # Veri modelleri
│   ├── Personel.cs        # Abstract base class
│   ├── TamZamanliPersonel.cs
│   ├── YariZamanliPersonel.cs
│   └── Departman.cs       # Enum
├── Interfaces/            # Arayüzler
│   ├── IMaasHesaplanabilir.cs
│   └── IRaporlanabilir.cs
├── Business/              # İş mantığı
│   └── PersonelYoneticisi.cs
├── Helpers/               # Yardımcı sınıflar
│   ├── Sabitler.cs
│   └── ValidationHelper.cs
├── Forms/                 # UI Formları
│   ├── SplashForm.cs      # Giriş ekranı
│   ├── MainForm.cs        # Ana form
│   ├── PersonelEkleForm.cs
│   └── RaporForm.cs
└── Program.cs             # Giriş noktası
```

## 🎓 Eğitim Amaçlı Notlar

Bu proje, Nesne Yönelimli Programlama (OOP) prensiplerini öğrenmek için tasarlanmıştır. Her sınıf ve metod detaylı Türkçe açıklamalarla (comments) belgelenmiştir.

### Öğrenme Noktaları

1. **Abstract Class ve Inheritance**
   - `Models/Personel.cs` dosyasına bakın
   - Abstract metodların nasıl tanımlandığını ve türetilmiş sınıflarda nasıl implement edildiğini inceleyin

2. **Interface Kullanımı**
   - `Interfaces/` klasöründeki dosyaları inceleyin
   - Bir sınıfın birden fazla interface'i nasıl implement ettiğini görün

3. **Encapsulation ve Validation**
   - `Models/Personel.cs` içindeki property'lere bakın
   - Private alanlar ve public property'ler ile kontrollü erişim örneğini görün

4. **Static Üyeler**
   - `Helpers/Sabitler.cs` - Static sabitler
   - `Business/PersonelYoneticisi.cs` - Singleton pattern
   - `Models/Personel.cs` - Static sayaç

5. **Constructor Overloading**
   - `Models/TamZamanliPersonel.cs` - 3 farklı kurucu
   - this ve base kullanımı örnekleri

## 📝 Örnek Kullanım

Uygulama ilk çalıştırıldığında 5 örnek personel ile gelir:
- 3 Tam Zamanlı Personel (farklı departmanlarda)
- 2 Yarı Zamanlı Personel

Bu verileri kullanarak tüm özellikleri test edebilirsiniz.

## 🛠️ Geliştirme

Projeyi Visual Studio 2022'de açıp düzenleyebilirsiniz. Tüm kod dosyaları detaylı açıklamalarla belgelenmiştir.

### Yeni Özellik Ekleme

1. Model değişikliği gerekiyorsa `Models/` klasöründen başlayın
2. İş mantığı için `Business/PersonelYoneticisi.cs` dosyasını güncelleyin
3. UI değişiklikleri için ilgili form dosyalarını düzenleyin

## 📄 Lisans

Bu proje eğitim amaçlıdır ve serbestçe kullanılabilir.

## 👨‍💻 Geliştirici

Nesne Yönelimli Programlama Projesi - 2026

---

**Not**: Bu proje, OOP prensiplerini öğrenmek ve uygulamak için geliştirilmiştir. Kodlar öğrenci seviyesine uygun, anlaşılır ve detaylı açıklamalarla yazılmıştır.
