using System.Web.Mvc;
using DSystems.Service.Contract;

namespace DSystems.Web.Controllers
{
    public class HomeController : DSystemsControllerBase
    {
        #region Ctor
        private readonly DSystems.Service.Contract.IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        } 
        #endregion

        public ActionResult Index()
        {
            var result = _userService.GetAllUsers();
            return View(result);
        }
	}
}