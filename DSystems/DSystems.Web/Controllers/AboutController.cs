using System.Web.Mvc;

namespace DSystems.Web.Controllers
{
    public class AboutController : DSystemsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}