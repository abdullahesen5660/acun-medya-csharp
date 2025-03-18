public class Araba
{
    public Marka Marka { get; set; }
    public string Model { get; set; }
    public Kapi Kapi { get; set; }
    public Pencere Pencere { get; set; }
    public Kasa Kasa { get; set; }
    public decimal Fiyat { get; set; }

    public Araba(Marka marka, string model, Kapi kapi, Pencere pencere, Kasa kasa, decimal fiyat)
    {
        Marka = marka;
        Model = model;
        Kapi = kapi;
        Pencere = pencere;
        Kasa = kasa;
        Fiyat = fiyat;
    }

    public void ArabaBilgisiYazdir()
    {
        Console.WriteLine($"Arabanın markası {Marka.MarkaAdi}, modeli {Model}, kapı sayısı {Kapi.KapiSayisi}, pencere sayısı {Pencere.PencereSayisi}, kasası {Kasa.KasaTipi}, fiyatı {Fiyat} TL’dir.");
    }
}
