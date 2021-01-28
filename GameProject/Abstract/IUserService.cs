using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IUserService
    {
        void SignUp();
        void ListInfo(User user);
        void ListGames();
        void UpdateInfo();
        void DeleteUser();
    }
}
