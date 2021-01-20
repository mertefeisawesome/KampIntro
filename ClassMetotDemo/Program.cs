using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID = 2; //iki müşteriyi kendim tanımladığım için ID'yi de 2 olarak belirliyorum
     
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Ad = "John";
            musteri1.Soyad = "Doe";
            musteri1.Telefon = "3565498655";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Ad = "Jane";
            musteri2.Soyad = "Doe";
            musteri2.Telefon = "2654962356"; //iki müşteri tanımladık, şimdilik yeterli

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.bilgileriniGoster(musteri1);

            Musteri musteri3 = new Musteri(); //yeni bir müşteriManager tanımladık. Ekle metoduyla üçüncü müşteriyi kullanıcıya tanımlatacağız
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 }; //diziye eleman eklemeyi bilmediğim için böyle biraz çirkin bir yola başvurdum

            System.Threading.Thread.Sleep(1000); //daha insani bir his vermesi için araya bekleme süreleri koydum
            musteriManager.Ekle(ref musteri3, ref ID); //üçüncü müşteriyi kullanıcıya tanımlatıyoruz
            System.Threading.Thread.Sleep(1000);
            musteriManager.tumunuListele(musteriler); //kullanıcının tanımladığı dahil tüm kullanıcıları listeliyoruz

            Console.WriteLine(musteri3.ID); //output: 3. Kodumuz çalışmış oley!
        }
    }
}
