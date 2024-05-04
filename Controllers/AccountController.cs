using Microsoft.AspNetCore.Mvc;
using HackerNewsClone.Models; // Ensure models are correctly defined

namespace HackerNewsClone.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Implement your authentication logic here
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Implement registration logic here
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
