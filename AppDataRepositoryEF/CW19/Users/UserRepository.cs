using AppDataRepositoryEF.CW19.Db;
using AppDomainCore.CW19.Users.Contract.Repository;
using CW19.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepositoryEF.CW19.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void Delete(int userId)
        {
            var user = GetUserById(userId);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int userId)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                throw new Exception("user not found");
            }
            return user;
        }

        public User Update(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
            return user;
        }
        public List<User> Search(string name)
        {
            return _context.Users.Where
                (x => x.FirstName.ToLower().Contains(name)
                || x.LastName.ToLower().Contains(name)
                ).ToList();
        }


    }
}
