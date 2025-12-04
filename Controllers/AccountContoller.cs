using Microsoft.AspNetCore.Mvc;

namespace FCIT_Event_Finder.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.sessionId = HttpContext.Session.GetString("id");
            ViewBag.sessionUserName =
           HttpContext.Session.GetString("username");
            return View();
        }
    }
}
