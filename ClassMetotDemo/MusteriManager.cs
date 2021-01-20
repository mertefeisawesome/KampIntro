using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (ref Musteri musteri, ref int ID)
        {
            ID++; //ana programda tanımladığımız ID değişkenini metodun içinde kullanıp her yeni kullanıcıda bir artırıyoruz
            musteri.ID = ID;
            Console.WriteLine("Yeni Müşteri Ekleme");
            Console.Write("Müşteri Adını Giriniz: ");
            musteri.Ad = Console.ReadLine();
            Console.Write("Müşteri Soyadını Giriniz: ");
            musteri.Soyad = Console.ReadLine();
            Console.Write("Müşteri Telefon Numarasını Giriniz: ");
            musteri.Telefon = Console.ReadLine();
            Console.WriteLine("Kullanıcı sisteme eklendi!"); //Bunda diziye ekleme kısmını çözemediğim için iyi niyetli bir çalışma olabildi sadece :D
        }

        public void Sil (Musteri musteri)
        {
            Console.WriteLine("Kullanıcı sistemden silindi!"); //Biraz spam mail listelerinden çıkarken yazan unsubscribedı hatırlatmadı değil ama daha iyisini yazamadım :)
        }

        public void bilgileriniGoster(Musteri musteri)
        {
            Console.WriteLine("Müşteri ID: " + musteri.ID + " için bilgiler:\n");
            Console.WriteLine("Ad: " + musteri.Ad);
            Console.WriteLine("Soyad: " + musteri.Soyad);
            Console.WriteLine("Telefon Numarası: " + musteri.Telefon + "\n");
            
        }

            public void tumunuListele (Musteri[] musteriler)
        {
            Console.WriteLine("Kayıtlı Müşterilerimiz");
            
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad: " + musteri.Ad);
                Console.WriteLine("Soyad: " + musteri.Soyad);
                Console.WriteLine("Telefon Numarası: " + musteri.Telefon + "\n");
            }
        }
    }
}
