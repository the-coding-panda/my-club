using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MyClub.Web.Views
{
    public abstract class MyClubRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyClubRazorPage()
        {
            LocalizationSourceName = MyClubConsts.LocalizationSourceName;
        }
    }
}
