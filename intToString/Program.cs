using System;

/// <summary>
/// Verilen uzun tam sayıyı (long) Türkçe metin karşılığına çevirir.
/// Negatif sayılar "eksi" ile başlar, sıfır için "sıfır" döner.
/// </summary>
/// <param name="sayi">Metne çevrilecek sayı.</param>
/// <returns>Sayıya karşılık gelen Türkçe metin ifadesi.</returns>
string SayiyiMetneCevir(long sayi)
{
    if (sayi == 0)
        return "sıfır";

    if (sayi < 0)
        return "eksi " + SayiyiMetneCevir(-sayi); 

    string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
    string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
    string[] binlikler = { "", "bin", "milyon", "milyar", "trilyon", "katrilyon" };

    string sonuc = "";
    int grupIndex = 0;

    while (sayi > 0)
    {
        int grup = (int)(sayi % 1000);

        if (grup != 0)
        {
            string grupStr = "";

            int yuzler = grup / 100;
            int onlarBas = (grup % 100) / 10;
            int birlerBas = grup % 10;

            if (yuzler > 0)
                grupStr += (yuzler == 1 ? "yüz" : birler[yuzler] + " yüz");

            if (onlarBas > 0)
                grupStr += (grupStr != "" ? " " : "") + onlar[onlarBas];

            if (birlerBas > 0)
                grupStr += (grupStr != "" ? " " : "") + birler[birlerBas];

            if (grup == 1 && grupIndex == 1)
                grupStr = "bin";

            sonuc = grupStr + (grupIndex > 0 ? " " + binlikler[grupIndex] : "") + (sonuc != "" ? " " + sonuc : "");
        }

        sayi /= 1000;
        grupIndex++;
    }

    return sonuc.Trim();
}


