using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using JoshTheGent.Controllers;

namespace JoshTheGent.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : JoshTheGentControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
