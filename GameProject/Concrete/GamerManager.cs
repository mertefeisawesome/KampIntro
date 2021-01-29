using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : UserManager
    {
        public void LoadBalance(Gamer user)
        {
            int balanceToAdd = 0;
            Console.WriteLine("Yüklemek istediğiniz tutarı giriniz: ");
            balanceToAdd = Convert.ToInt32(Console.ReadLine());
            user.Balance += balanceToAdd;
        }
        public void BuyGame(Gamer user, Game game, GameManager gameManager, int discountPercent = 0)
        {
            if(user.Balance > gameManager.ReturnPrice(game, discountPercent))
            {
                user.Balance -= gameManager.ReturnPrice(game, discountPercent);
                user._games.Add(game);
                Console.WriteLine(game.Name + " adlı oyun satın alındı. İyi oyunlar! Kalan bakiye: " + user.Balance);
            }
            else
            {
                Console.WriteLine("Bakiyeniz yetersiz.");
            }
            
        }

        public void ListGames(Gamer user)
        {
            Console.WriteLine(user.Name + " " + user.Surname + " adlı kullanıcının sahip olduğu oyunlar:\n");
            foreach (Game item in user._games)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
