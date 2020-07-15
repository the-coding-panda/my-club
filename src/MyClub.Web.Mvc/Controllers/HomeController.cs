using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyClub.Controllers;

namespace MyClub.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyClubControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
