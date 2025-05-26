# SayiyiMetneCevir

Bu proje, verilen bir sayıyı Türkçe metin karşılığına çeviren bir C# uygulamasıdır. Negatif sayıları da destekler ve sayının yazı ile okunuşunu üretir.

## 🔧 Özellikler

- 0'dan başlayarak trilyonlara kadar sayıları destekler.
- Negatif sayılar için `"eksi"` öneki ekler.
- `long` veri tipi ile oldukça büyük sayılar işlenebilir.
- Gereksiz ifadeleri düzeltir: Örn. "bir bin" yerine "bin" yazılır.

## 🧠 Kullanılan Yöntem

Metod, sayıyı binlik gruplara ayırarak her grubu ayrı ayrı çözümler. Recursive (özyinelemeli) olarak sadece negatif sayılar için kendisini çağırır.

## 📌 Örnek Kullanım

```csharp
long sayi = -123456;
string sonuc = SayiyiMetneCevir(sayi);
Console.WriteLine(sonuc);
// Çıktı: "eksi yüz yirmi üç bin dört yüz elli altı"
