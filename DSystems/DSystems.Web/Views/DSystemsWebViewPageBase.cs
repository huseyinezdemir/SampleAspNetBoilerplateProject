using Abp.Web.Mvc.Views;

namespace DSystems.Web.Views
{
    public abstract class DSystemsWebViewPageBase : DSystemsWebViewPageBase<dynamic>
    {

    }

    public abstract class DSystemsWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DSystemsWebViewPageBase()
        {
            LocalizationSourceName = DSystemsConsts.LocalizationSourceName;
        }
    }
}