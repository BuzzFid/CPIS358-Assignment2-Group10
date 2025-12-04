using FCIT_Event_Finder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks;
using System.Diagnostics;

namespace FCIT_Event_Finder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SetSession("id", Guid.NewGuid().ToString());
            // Check if the user is authenticated
            if (User.Identity.IsAuthenticated)
            {
                // User is logged in, get their username
                SetCookies("userName", User.Identity.Name);
                // create a session with username
                SetSession("username", User.Identity.Name);

            }
            else
            {
                // User is not logged in, set a cookie with "Guest"
                SetCookies("userName", "guest");
                // create a session with username
                SetSession("username", "guest");
            }
            // Get the broswer type
            SetCookies("broswerName", Request.Headers["User-Agent"].ToString());
              return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SetCookies(string cookieName, string cookieValue)
        {
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(15), // Cookie expires in 14 days
                HttpOnly = true,
          
            Secure = true,
                SameSite = SameSiteMode.Strict
               
            };
            Response.Cookies.Append(cookieName, cookieValue, options);
            return Ok("Cookies has been set.");
        }

        public IActionResult SetSession(string key, string value)
        {
            // Set session value
            HttpContext.Session.SetString(key, value);
            return RedirectToAction("Index");
        }
    }
}
