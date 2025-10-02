using ltweb_bt5.Models;
using Microsoft.AspNetCore.Mvc;

namespace ltweb_bt5.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UserManualValid()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserManualValid(User user)
        {
            String pass = user.Password;
            if (pass.Length < 7)
            {
                ViewBag.PassErr = "Mat khau phai co toi thieu 7 ki tu";
                return View();
            }
            return Content("Ban da nhap dung");
        }
        public IActionResult UserAnnotation(User user)
        {
            if (ModelState.IsValid)
            {
                return Content("user state valid");
            }

            return View();
        }
    }
}
