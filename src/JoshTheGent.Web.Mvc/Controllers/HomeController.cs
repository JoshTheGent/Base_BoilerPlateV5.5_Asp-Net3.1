using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using JoshTheGent.Controllers;

namespace JoshTheGent.Web.Controllers
{
    public class HomeController : JoshTheGentControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
