using DataManagement.Business;
using DataManagement.Entities;
using DataManagement.Repository;
using System.Collections.Generic;
using System.Linq;

namespace DataManagement.Business
{
    /// <summary>
    /// This user manager call the UserRepository that only uses Dapper 
    /// The userRepository is passed into the constructor via dependency injection
    /// from the service manager
    /// </summary>
    public class UserManager1 : IUserManager
    {
        IUserRepository _userRepository;
        public UserManager1(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool AddUser(User user)
        {
            return _userRepository.AddUser(user);
        }
        public bool DeleteUser(int userId)
        {
            return _userRepository.DeleteUser(userId);
        }
        public IList<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }
        public User GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }
        public bool UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
