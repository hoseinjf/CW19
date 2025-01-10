using AppDomainCore.CW19.Users.Contract.Repository;
using AppDomainCore.CW19.Users.Contract.Service;
using CW19.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User Add(User user)
        {
            user = new User()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = user.BirthDate,
                Gender = user.Gender,
                MembershipType = user.MembershipType,
                Nationalژode = user.Nationalژode,
                Phone = user.Phone,
                RegisterDate = DateTime.Now,
            };
            _userRepository.Add(user);
            return user;
        }

        public void Delete(int userId)
        {
            if (userId !=0) 
            {
                _userRepository.Delete(userId);
            }
            else
            {
                throw new Exception(" user id is null !!! ");
            }
        }

        public List<User> GetAllUser()
        {
            List<User> users =  _userRepository.GetAllUser();
            if (users == null)
            {
                return new List<User>();
            }
            return users;
        }

        public User GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }

        public User Update(int userId)
        {
            var user = _userRepository.GetUserById(userId);
            user = new User()
            {
                Id = userId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = user.BirthDate,
                Gender = user.Gender,
                MembershipType = user.MembershipType,
                Nationalژode = user.Nationalژode,
                Phone = user.Phone,
                RegisterDate = DateTime.Now,
            };
            return _userRepository.Update(user.Id);
        }
    }
}
