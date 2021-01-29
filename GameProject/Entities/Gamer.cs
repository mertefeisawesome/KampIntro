using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Gamer : User
    {
        public List<Game> _games = new List<Game>();
        public float Balance { get; set; }

    }
}
