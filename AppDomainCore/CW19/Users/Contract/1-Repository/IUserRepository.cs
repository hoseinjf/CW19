﻿using CW19.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CW19.Users.Contract.Repository
{
    public interface IUserRepository
    {
        User Add(User user);
        User Update(User user);
        void Delete(int userId);
        User GetUserById(int userId);
        List<User> GetAllUser();
        List<User> Search(string name);

    }
}
