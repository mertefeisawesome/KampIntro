using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IUserService
    {
        void SignUp(User user, ref int userID);
        void ListInfo(User user);
        void UpdateInfo(User user);
        void DeleteUser(User user);
    }
}
