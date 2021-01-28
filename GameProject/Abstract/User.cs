using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    class User
    {
        public int Id { get; set; }
        public int TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
