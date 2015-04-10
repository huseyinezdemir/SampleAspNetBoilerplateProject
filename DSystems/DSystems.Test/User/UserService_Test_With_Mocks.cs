using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using DSystems.Service;
using DSystems.Service.Contract;
using NSubstitute;
using Shouldly;
using Xunit;

namespace DSystems.Test.User
{
    public class UserService_Test_With_Mocks : SimpleDSystemTestBase
    {
        private readonly IUserService _userService;

        public UserService_Test_With_Mocks()
        {
            var users = new List<Domain.User>
            {
                new Domain.User{FirstName = "Ahmet",IsActive = true},
                new Domain.User{FirstName = "Mehmet",IsActive = true}
            };

            var userRepository = NSubstitute.Substitute.For<IRepository<Domain.User>>();
            userRepository.GetAllList().Returns(users);
            
            _userService = new UserService(userRepository);
        }

        [Fact]
        public void Should_Get_All_User()
        {
            var users = _userService.GetAllUsers();
            users.ShouldNotBe(null);
            users.Count.ShouldBe(2);
        }
    }
}
