using KendoApplication.Models;
using KendoApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KendoApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly string ConnectionString;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            ConnectionString = _configuration.GetSection("ConnectionStrings:DefaultCon").Value;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetEmployeeData()
        {
            try
            {
                EmployeeService service = new EmployeeService(ConnectionString);
                List<Employee> result = service.GetData();
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
