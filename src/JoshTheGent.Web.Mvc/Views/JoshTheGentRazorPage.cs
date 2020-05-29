using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace JoshTheGent.Web.Views
{
    public abstract class JoshTheGentRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected JoshTheGentRazorPage()
        {
            LocalizationSourceName = JoshTheGentConsts.LocalizationSourceName;
        }
    }
}
