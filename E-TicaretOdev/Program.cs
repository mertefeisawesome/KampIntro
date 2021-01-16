using System;

namespace E_TicaretOdev
{
    class Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Marka = "Samsung";
            urun1.Model = "Galaxy Tab A 8";
            urun1.Fiyat = 1199;

            Urun urun2 = new Urun();
            urun2.Marka = "Lenovo";
            urun2.Model = "Tab M10 Plus";
            urun2.Fiyat = 1999;

            Urun urun3 = new Urun();
            urun3.Marka = "TP-Link";
            urun3.Model = "TL-WA854RE Wi-Fi Range Extender";
            urun3.Fiyat = 149;

            Urun urun4 = new Urun();
            urun4.Marka = "Lenovo";
            urun4.Model = "Ideapad 3";
            urun4.Fiyat = 6599;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            Console.WriteLine("For döngüsü:\n");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Marka: " + urunler[i].Marka);
                Console.WriteLine("Model: " + urunler[i].Model);
                Console.WriteLine("Fiyat: " + urunler[i].Fiyat + "TL\n");
            }

            Console.WriteLine("Foreach döngüsü:\n");

            foreach (var urun in urunler)
            {
                Console.WriteLine("Marka: " + urun.Marka);
                Console.WriteLine("Model: " + urun.Model);
                Console.WriteLine("Fiyat: " + urun.Fiyat + "TL\n");
            }

            Console.WriteLine("While döngüsü:\n");

            int sayi = 0;

            while (sayi < urunler.Length)
            {
                Console.WriteLine("Marka: " + urunler[sayi].Marka);
                Console.WriteLine("Model: " + urunler[sayi].Model);
                Console.WriteLine("Fiyat: " + urunler[sayi].Fiyat + "TL\n");
                sayi++;
            }


        }
    }
}