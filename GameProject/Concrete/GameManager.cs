using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public float ReturnPrice(Game game, int discountPercent = 0)
        {
            if (discountPercent == 0) 
            {
                return game.Price;
            }
            else
            {
                return game.Price * (1 - discountPercent / 100);
            }
            
        }
    }
}
