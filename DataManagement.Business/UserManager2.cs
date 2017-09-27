using DataManagement.Business;
using DataManagement.Entities;
using DataManagement.Repository;
using System.Collections.Generic;
using System.Linq;

namespace DataManagement.Business
{
    public class UserManager2 : IUserManager
    {
        //IUserRepository1 _userRepository;
        IRepository<User> _userRepository;
        public UserManager2(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public bool AddUser(User user)
        {
            return _userRepository.Add(user);
        }
        public bool DeleteUser(int userId)
        {
            return _userRepository.Delete(userId);
        }
        public IList<User> GetAllUser()
        {
            return _userRepository.Get().ToList<User>();
        }
        public User GetUserById(int userId)
        {
            return _userRepository.Get(userId);
        }
        public bool UpdateUser(User user)
        {
            return _userRepository.Update(user);
        }
    }
}
