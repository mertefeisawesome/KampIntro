using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserManager : IUserService
    {
        public void SignUp(User user, ref int userID)
        {
            userID += 1;
            user.Id = userID;
            Console.WriteLine("Adınızı giriniz: ");
            user.Name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz: ");
            user.Surname = Console.ReadLine();
            Console.WriteLine("TC Kimlik Numaranınızı giriniz: ");
            user.NationalId = Console.ReadLine();
            Console.WriteLine("Doğum yılınızı giriniz: ");
            user.YearOfBirth = Console.ReadLine();
            if (CheckIfRealPerson(user) == true)
            {
                Console.WriteLine("Kullanıcı kaydı başarılı");
            }
            else
            {
                user.Name = "";
                user.Surname = "";
                user.NationalId = "";
                user.YearOfBirth = "";
                Console.WriteLine("Bilgiler yanlış. Kullanıcı kaydı yapılamadı.");
            }
            
        }

        public void ListInfo(User user)
        {
            Console.WriteLine("ID: " + user.Id);
            Console.WriteLine("Adı: " + user.Name);
            Console.WriteLine("Soyadı: " + user.Surname);
            Console.WriteLine("TC Kimlik Numarası: " + user.NationalId);
            Console.WriteLine("Doğum yılı: " + user.YearOfBirth);
        }
        
       

        public void UpdateInfo(User user)
        {
            Console.WriteLine("Kullanıcı bilgileri güncellendi.");
        }

        public void DeleteUser(User user)
        {
            user.Name = "";
            user.Surname = "";
            user.NationalId = "";
            user.YearOfBirth = "";
            Console.WriteLine("Kullanıcı silindi.");
        }

        private bool CheckIfRealPerson (User user)
        {
            return user.Name == "Mert" && user.Surname == "Efe" && user.NationalId == "12345";
        }
    }
}
