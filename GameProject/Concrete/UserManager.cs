using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserManager : IUserService
    {
        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void ListGames()
        {
            throw new NotImplementedException();
        }

        public void ListInfo(User user)
        {
            foreach property in user
            {
                Console.WriteLine(user.property);
            }
        }

        public void SignUp()
        {
            throw new NotImplementedException();
        }

        public void UpdateInfo()
        {
            throw new NotImplementedException();
        }
    }
}
