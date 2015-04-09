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
    public class UserService_Test_With_Mocks : DSystemsTestBase
    {
        private readonly IUserService _userService;

        public UserService_Test_With_Mocks()
        {

            var users = new List<Domain.User>();

            users.Add(new Domain.User { FirstName = "Huseyin" });
            users.Add(new Domain.User { FirstName = "Osman" });

            var userRepository = NSubstitute.Substitute.For<IRepository<Domain.User>>();

            userRepository.GetAllList().Returns(users);

            _userService = new UserService(userRepository);


        }

        [Fact]
        public void Should_Get_All_User()
        {
            var result = _userService.GetAllUsers();

            result.Count.ShouldBe(2);

            result.FirstOrDefault(x => x.FirstName == "Oguz").ShouldNotBe(null);
        }
    }
}
