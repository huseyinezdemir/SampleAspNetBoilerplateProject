using System.Collections.Generic;
using Abp.Application.Services;
using DSystems.Domain;

namespace DSystems.Service.Contract
{
    public interface IUserService : IApplicationService
    {
        void CreatePerson(User entity);
        List<User> GetAllUsers();
    }
}
