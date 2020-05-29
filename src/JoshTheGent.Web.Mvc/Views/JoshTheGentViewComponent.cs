using Abp.AspNetCore.Mvc.ViewComponents;

namespace JoshTheGent.Web.Views
{
    public abstract class JoshTheGentViewComponent : AbpViewComponent
    {
        protected JoshTheGentViewComponent()
        {
            LocalizationSourceName = JoshTheGentConsts.LocalizationSourceName;
        }
    }
}
