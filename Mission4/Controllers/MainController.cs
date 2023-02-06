using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission4.Models;

namespace Mission4.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }
        /*Overloaded with POST option*/
        [HttpPost]
        public IActionResult Calculator(GradeCalculationModel model)
        {
            return View();
        }
    }
}