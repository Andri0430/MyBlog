using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MyBlog.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var claim = HttpContext.User.Claims;
            var userFullName = claim.Where(x => x.Type == "name").FirstOrDefault()?.Value;

            ViewData["FullName"] = userFullName;
            return View();
        }
    }
}
