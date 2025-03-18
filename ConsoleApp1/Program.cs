using System;

public class Program
{
    public static void Main(string[] args)
    {
        Marka togg = new Marka("togg");
        string model = "t10x";
        Kapi kapi = new Kapi(4);
        Pencere pencere = new Pencere(4);
        Kasa kasa = new Kasa("suv");
        decimal fiyat = 1649000m;

        Araba bmwX5 = new Araba(togg, model, kapi, pencere, kasa, fiyat);

        bmwX5.ArabaBilgisiYazdir();
    }
}
