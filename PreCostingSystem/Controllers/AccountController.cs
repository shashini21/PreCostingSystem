using Microsoft.AspNetCore.Mvc;
using PRC_PreCosting_MVC.Data;
using PRC_PreCosting_MVC.Models;

namespace PRC_PreCosting_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _context.Users
                .FirstOrDefault(u =>
                    u.LogName == model.LogName);

            if (user == null)
            {
                ModelState.AddModelError(
                    "",
                    "Invalid login name or password.");

                return View(model);
            }

            if (user.Password != model.Password)
            {
                ModelState.AddModelError(
                    "",
                    "Invalid login name or password.");

                return View(model);
            }

            // Store logged-in user information
            HttpContext.Session.SetInt32(
                "UserId",
                user.UserId);

            HttpContext.Session.SetString(
                "LogName",
                user.LogName);

            HttpContext.Session.SetString(
                "UserName",
                user.UserName ?? "");

            HttpContext.Session.SetInt32(
                "AccessLevel",
                user.AccessLevel ?? 0);

            // Update last login date
            user.LastLoginDate = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction(
                "Index",
                "Home");
        }
    }
}