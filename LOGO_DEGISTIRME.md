"# LOGO DEĞİŞTİRME REHBERİ

Bu dosya, uygulamadaki logoyu nasıl değiştireceğinizi adım adım açıklar.

## Yöntem 1: Basit Yöntem (Önerilen)

1. **Logonuzu Hazırlayın**
   - PNG formatında olmalı
   - Transparan (şeffaf) arka plan olmalı
   - Önerilen boyut: 150x150 piksel (kare)

2. **Logo Dosyasını Kopyalayın**
   - Logo dosyanızı `Resources` klasörüne kopyalayın
   - Eğer `Resources` klasörü yoksa, proje ana dizininde oluşturun

3. **Visual Studio'da Projeyi Açın**
   - `PersonelYonetimSistemi.sln` dosyasını çift tıklayın

4. **Designer'da Logo Ekleyin**
   - Solution Explorer'da `Forms` > `SplashForm.cs` dosyasına çift tıklayın
   - Eğer kod görünümü açılırsa, altta `SplashForm.cs [Design]` sekmesine tıklayın
   - Formdaki `pictureBoxLogo` kontrolüne tıklayın
   - Sağ taraftaki Properties penceresinde `Image` özelliğini bulun
   - `Image` yanındaki `...` butonuna tıklayın
   - Açılan pencerede:
     - `Local resource` seçeneğini seçin
     - `Import...` butonuna tıklayın
     - Logo dosyanızı seçin
     - `OK` butonuna tıklayın

5. **Kaydedin ve Çalıştırın**
   - `File` > `Save All` (veya Ctrl+Shift+S)
   - `Debug` > `Start Debugging` (veya F5)

## Yöntem 2: Kod ile Ekleme

1. **Logo Dosyasını Projeye Ekleyin**
   - Logo dosyanızı proje ana dizinine kopyalayın (örnek: `logo.png`)
   - Solution Explorer'da projeye sağ tıklayın
   - `Add` > `Existing Item` seçin
   - Logo dosyanızı seçin ve `Add` butonuna tıklayın

2. **Logo Dosyasının Özelliklerini Ayarlayın**
   - Solution Explorer'da logo dosyasına sağ tıklayın
   - `Properties` seçin
   - `Copy to Output Directory` özelliğini `Copy if newer` yapın

3. **Kodu Güncelleyin**
   - `Forms\SplashForm.cs` dosyasını açın
   - `SplashForm_Load` metodunu bulun (yoksa ekleyin)
   - Aşağıdaki kodu ekleyin:

```csharp
private void SplashForm_Load(object sender, EventArgs e)
{
    // Form başlangıçta görünmez
    this.Opacity = 0;
    
    // Logo yükle
    try
    {
        string logoPath = System.IO.Path.Combine(Application.StartupPath, "logo.png");
        if (System.IO.File.Exists(logoPath))
        {
            pictureBoxLogo.Image = Image.FromFile(logoPath);
        }
    }
    catch
    {
        // Logo yüklenemezse varsayılan görünüm kalır
    }
}
```

4. **Kaydedin ve Çalıştırın**
   - `File` > `Save All`
   - `Debug` > `Start Debugging`

## Yöntem 3: Resources Kullanarak (En Profesyonel)

1. **Resources Dosyasını Açın**
   - Solution Explorer'da `Properties` klasörünü genişletin
   - `Resources.resx` dosyasına çift tıklayın

2. **Logo Ekleyin**
   - Üstteki dropdown'dan `Images` seçin
   - `Add Resource` > `Add Existing File` tıklayın
   - Logo dosyanızı seçin
   - Logo eklendiğinde adını not edin (örnek: `logo`)

3. **Kodu Güncelleyin**
   - `Forms\SplashForm.cs` dosyasını açın
   - `SplashForm_Load` metodunu bulun
   - Aşağıdaki kodu ekleyin:

```csharp
private void SplashForm_Load(object sender, EventArgs e)
{
    // Form başlangıçta görünmez
    this.Opacity = 0;
    
    // Logo yükle (Resources'tan)
    try
    {
        pictureBoxLogo.Image = Properties.Resources.logo; // 'logo' yerine kendi adınızı yazın
    }
    catch
    {
        // Logo yüklenemezse varsayılan görünüm kalır
    }
}
```

4. **Kaydedin ve Çalıştırın**

## Sorun Giderme

### Logo Görünmüyor
- Logo dosyasının doğru yerde olduğundan emin olun
- Logo dosyasının PNG formatında olduğunu kontrol edin
- Visual Studio'yu kapatıp tekrar açmayı deneyin
- `Build` > `Clean Solution` ardından `Build` > `Build Solution` yapın

### Logo Bozuk Görünüyor
- Logo boyutunu kontrol edin (çok büyük veya çok küçük olabilir)
- PictureBox'ın `SizeMode` özelliğini `Zoom` yapın:
  - Designer'da `pictureBoxLogo`'ya tıklayın
  - Properties'de `SizeMode` özelliğini bulun
  - `Zoom` seçin

### Transparan Arka Plan Çalışmıyor
- Logo dosyasının gerçekten transparan PNG olduğundan emin olun
- Photoshop, GIMP veya online araçlarla logoyu tekrar kaydedin

## Logo Boyut Önerileri

- **Minimum**: 100x100 piksel
- **Önerilen**: 150x150 piksel
- **Maksimum**: 300x300 piksel
- **Format**: PNG (transparan arka plan)
- **Renk**: Beyaz veya açık renkli (koyu arka plan üzerinde görünecek)

## Ek İpuçları

1. **Logo Merkezleme**: PictureBox zaten merkezde konumlandırılmış, ek ayar gerekmez
2. **Logo Animasyonu**: Mevcut fade-in animasyonu logo ile birlikte çalışır
3. **Birden Fazla Logo**: Ana formda da logo eklemek isterseniz, `MainForm.cs` dosyasında benzer adımları uygulayın

---

**Yardıma mı ihtiyacınız var?**
Sorun yaşıyorsanız, README.md dosyasındaki proje yapısını inceleyin veya kod içindeki açıklamaları okuyun.
