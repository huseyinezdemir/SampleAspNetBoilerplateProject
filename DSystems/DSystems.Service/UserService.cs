using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using DSystems.Domain;
using DSystems.Service.Contract;

namespace DSystems.Service
{
    public class UserService : IUserService
    {
        #region Ctor
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion

        public void CreatePerson(User entity)
        {
            var result = _userRepository.Insert(entity);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllList().Where(y => y.IsActive).ToList();
        }
    }
}
