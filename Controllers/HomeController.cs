using System.Diagnostics;
using ltweb_bt5.Models;
using Microsoft.AspNetCore.Mvc;

namespace ltweb_bt5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var employee = new List<Employee>();
            var employee1 = new Employee();
            employee1.id = 1;
            employee1.fullName = "John Smith";
            employee1.gender = "Male";
            employee1.phone = "0123456789";
            employee1.email = "john@example.com";
            employee1.salary = 10000;
            employee1.status = "test";
            var employee2 = new Employee();
            employee2.id = 2;
            employee2.fullName = "Alice Smith";
            employee2.gender = "female";
            employee2.phone = "0123456789";
            employee2.email = "alice@example.com";
            employee2.salary = 10500;
            employee2.status = "test";
            var employee3 = new Employee();
            employee3.id = 3;
            employee3.fullName = "Bob Smith";
            employee3.gender = "Male";
            employee3.phone = "0123456789";
            employee3.email = "bob@example.com";
            employee3.salary = 10600;
            employee3.status = "test";
            employee.Add(employee1);
            employee.Add(employee2);
            employee.Add(employee3);

            ViewBag.employee = employee;
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
    }
}
