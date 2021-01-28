using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public float MakeDiscount(Game game, int percent)
        {
            return game.Price * (1 - percent / 100);
        }

        public float ReturnPrice(Game game)
        {
            return game.Price;
        }
    }
}
