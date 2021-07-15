using Ajax.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax.Controllers
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
            return View();
        }
        public JsonResult SaveEmpInfo(EmployeeModel employeeModel)
        {
            List<string> email = new List<string>();
            email.Add("dhesh@gmail.com");
            email.Add("hari@gmail.com");
            email.Add("fazil@gmail.com");
            if (email.Contains(employeeModel.Email))
            {
                return Json(new { msg = "Success", firstName = employeeModel.FirstName,
                    lastName = employeeModel.LastName, gender = employeeModel.Gender, email = employeeModel.Email,
                    skills=employeeModel.Skills});
            }
            else
            {
                return Json(new { msg = "Failure"});
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public JsonResult Dropdown(string drop)
        {
            return Json(new { msg = "success", drop = drop });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
