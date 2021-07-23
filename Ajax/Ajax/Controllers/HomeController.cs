using Ajax.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
                return Json(new
                {
                    msg = "Success",
                    firstName = employeeModel.FirstName,
                    lastName = employeeModel.LastName,
                    gender = employeeModel.Gender,
                    email = employeeModel.Email,
                    skills = employeeModel.Skills
                });
            }
            else
            {
                return Json(new { msg = "Failure" });
            }
        }
    }
}
