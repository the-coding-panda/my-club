using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyClub.Web.Views
{
    public abstract class MyClubViewComponent : AbpViewComponent
    {
        protected MyClubViewComponent()
        {
            LocalizationSourceName = MyClubConsts.LocalizationSourceName;
        }
    }
}
