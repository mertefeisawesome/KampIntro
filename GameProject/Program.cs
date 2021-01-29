using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int userID = 0;
            GamerManager gamerManager = new GamerManager();
            GameManager gameManager = new GameManager();
            Gamer user1 = new Gamer();

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "Worms";
            game1.Price = 20;

            Game game2 = new Game();
            game1.Id = 2;
            game2.Name = "NFS";
            game2.Price = 30;

            Game game3 = new Game();
            game3.Id = 3;
            game3.Name = "PUBG";
            game3.Price = 100;

            //Kullanıcı kaydı. Doğru olması için şu değerler girilmeli: Ad = Mert, Soyad = Efe, TC Kimlik No = 12345
            gamerManager.SignUp(user1, ref userID);

            //Bakiye yükleme. 100 lira yükleyelim
            gamerManager.LoadBalance(user1);

            //Oyun satınalma
            gamerManager.BuyGame(user1, game1, gameManager);

            //İndirimli oyun satın alma
            gamerManager.BuyGame(user1, game2, gameManager, 20);

            //Yetersiz bakiye
            gamerManager.BuyGame(user1, game3, gameManager);

            //Kullanıcının oyunlarını listeleme
            gamerManager.ListGames(user1);

        }
    }
}
