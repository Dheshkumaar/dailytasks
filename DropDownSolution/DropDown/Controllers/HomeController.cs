using DropDown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace DropDown.Controllers
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
        public JsonResult getCountry()
        {
            List<string> Country = new List<string>();
            Country.Add("India");
            Country.Add("USA");
            Country.Add("UK");
            Country.Add("Australia");
            return Json(new { msg = "Success", Country = Country });
        }
        public JsonResult getStates(string drop)
        {
            List<string> state = new List<string>();
            switch (drop.ToLower())
            {
                case "india":
                    state.Add("TamilNadu");
                    state.Add("AndhraPradesh");
                    break;
                case "usa":
                    state.Add("California");
                    state.Add("Washington");
                    break;
                case "uk":
                    state.Add("Scotland");
                    state.Add("England");
                    break;
                case "australia":
                    state.Add("New South Wales");
                    state.Add("Queensland");
                    break;
            }
            return Json(new { msg = "success", drop = state });
        }
        public JsonResult City(string state)
        {
            List<string> city = new List<string>();
            switch (state.ToLower())
            {
                case "tamilnadu":
                    city.Add("Chennai");
                    city.Add("Vellore");
                    break;

                case "andhrapradesh":
                    city.Add("Visakhapatnam");
                    city.Add("Nellore");
                    break;

                case "california":
                    city.Add("Los Angeles");
                    city.Add("San Diego");
                    break;

                case "washington":
                    city.Add("Olympia");
                    city.Add("Vancouver");
                    break;

                case "scotland":
                    city.Add("GlasGow");
                    city.Add("Livingston");
                    break;

                case "england":
                    city.Add("Liverpool");
                    city.Add("Birmingham");
                    break;

                case "new south wales":
                    city.Add("Sydney");
                    city.Add("Albury");
                    break;

                case "queensland":
                    city.Add("Brisbane");
                    city.Add("Nambour");
                    break;
            }
            return Json(new { msg = "success", State = city });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
