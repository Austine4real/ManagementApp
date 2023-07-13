using Microsoft.AspNetCore.Mvc;

namespace ManagementApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
