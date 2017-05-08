using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Q400Calculator.Models.CalculatorViewModels;

namespace Q400Calculator.Controllers
{
    public class PlaneCalculatorController : Controller
    {
        // GET: PlaneCalculator
        public IActionResult Index()
        {


            return View();
        }

        // GET: PlaneCalculator/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        
    }
}