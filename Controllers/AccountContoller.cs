using Microsoft.AspNetCore.Mvc;

namespace FCIT_Event_Finder.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
