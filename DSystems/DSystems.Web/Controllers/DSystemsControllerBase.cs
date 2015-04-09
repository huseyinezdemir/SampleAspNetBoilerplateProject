using Abp.Web.Mvc.Controllers;

namespace DSystems.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class DSystemsControllerBase : AbpController
    {
        protected DSystemsControllerBase()
        {
            LocalizationSourceName = DSystemsConsts.LocalizationSourceName;
        }
    }
}