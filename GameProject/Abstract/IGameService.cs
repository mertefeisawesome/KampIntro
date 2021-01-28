using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameService
    {
        float ReturnPrice(Game game);
        float MakeDiscount(Game game, int percent);
    }
}
