using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSystems.Service.Contract;
using Shouldly;
using Xunit;

namespace DSystems.Test.User
{
    public class UserService_Test_With_Db : SimpleDSystemTestBase
    {
        private readonly IUserService _userService;

        public UserService_Test_With_Db()
        {
            _userService = LocalIocManager.Resolve<IUserService>();
        }

        [Fact]
        public void Should_Get_All_Users()
        {
            var users = _userService.GetAllUsers();
            users.ShouldNotBe(null);
            users.Count.ShouldBeGreaterThan(0);
        }
    }
}
