using Microsoft.AspNetCore.Mvc;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.temperature = 99.5;
            ViewBag.sclae = "celcius";
            ViewBag.message = HttpContext.Session.GetString("message");
            return View();
        }
        public ActionResult CheckTemperature()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckTemperature(float temperature, string unit)
        {
            bool isFahrenheit = unit == "Fahrenheit";
            string message = TemperatureChecker.CheckTemperature(temperature, isFahrenheit);
            ViewBag.Message = message;
            return View();
        }
    }
}
    

