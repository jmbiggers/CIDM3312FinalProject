using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q400Calculator.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Q400Calculator.Models;
namespace Q400Calculator.Controllers
{
    public class CalculateController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CalculateController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Calculate
        public IActionResult Index()
        {


            Random rand = new Random();
            int windSpeed = rand.Next(0, 26);
            int windDirection = rand.Next(0, 360);
            int heading = 0;
            int distance = 0;
            int windComponent;

        ////////////// Creating and Instance ///////////////

            CalculatorModel cm = new CalculatorModel();

       /////////////// Gathering Data /////////////////////

            cm.Land = new LandingData();
            cm.Climb = new ClimbData();
            cm.TakeOff = new TakeOffData();
            cm.Calculate = new CalculatorData();

            cm.Calculate.Icing = false;
            cm.Calculate.Rain = false;
            cm.Calculate.Snow = false;
            cm.Calculate.Headwind = false;
            cm.Calculate.Tailwind = false;
            cm.Calculate.WindSpeed = windSpeed;
            cm.Calculate.Heading = heading;
            cm.Calculate.Distance = distance;
            cm.Calculate.WindDirection = windDirection;
            cm.Calculate.Landing = false;
            cm.Calculate.TakeOff = false;
            cm.Calculate.Name = Console.ReadLine();
            

            int windAngle = windDirection - heading;


        ////////////////// VR/V2 Calculation ///////////////////////
            if (cm.TakeOff.vr > cm.TakeOff.v2)
            {
                cm.TakeOff.v2 = cm.TakeOff.vr;
            }

        ////////////////// Headwind and Tailwind Calculations ///////////////

            //Headwind/Tailwind calculation.
            if (windAngle <= 36)
            {
                cm.Calculate.Tailwind = true;

                windComponent = windSpeed * Convert.ToInt32(Math.Cos(windAngle));
                if(cm.Calculate.TakeOff == true)
                {
                    cm.TakeOff.vr += windComponent;
                    cm.TakeOff.v2 += windComponent;
                }
                else if(cm.Calculate.Landing == true)
                {
                    cm.Land.vapp += windComponent;
                    cm.Land.vga += windComponent;
                    cm.Land.vref += windComponent;
                }
            }
            if (windAngle >= 324)
            {
                cm.Calculate.Headwind = true;
                windComponent = windSpeed * Convert.ToInt32(Math.Cos(windAngle));

                if (cm.Calculate.TakeOff == true)
                {
                    cm.TakeOff.vr -= windComponent;
                    cm.TakeOff.v2 -= windComponent;
                }
                else if (cm.Calculate.Landing == true)
                {
                    cm.Land.vapp -= windComponent;
                    cm.Land.vga -= windComponent;
                    cm.Land.vref -= windComponent;
                }
            }

      /////////////////////// Slow Speeds /////////////////////////
            //warnings for slow to near stall speeds.
            if(cm.TakeOff.flaps == 5 && cm.TakeOff.vr == 108)
            {
                Console.Write("At Current Flap angle, You must Speed Up!");
            }

            if (cm.TakeOff.flaps == 10 && cm.TakeOff.vr == 104)
            {
                Console.Write("At Current Flap angle, You must Speed Up!");
            }

            if (cm.TakeOff.flaps == 15 && cm.TakeOff.vr == 100)
            {
                Console.Write("At Current Flap angle, You must Speed Up!");
            }

            if (cm.TakeOff.flaps == 5 && cm.TakeOff.vr == 97)
            {
                Console.Write("At Current Flap angle, You must Speed Up!");
            }

            if (cm.TakeOff.flaps == 15 && cm.TakeOff.vr == 96 || cm.TakeOff.flaps == 10 && cm.TakeOff.vr == 96)
            {
                Console.Write("At Current Flap angle, You must Speed Up!");
            }

         //// Flaps for landing and setting speeds for this instance. //////
            if(cm.Land.flaps == 5)
            {
                cm.Land.vref = cm.Land.vga;
            }
            if(cm.Land.flaps == 35)
            {
                cm.Land.vapp = cm.Land.vref;
                cm.Land.vga = cm.Land.vref;
            }

            ////////////// Icing Conditions Calculations ///////////////

            if (cm.Calculate.Icing == true)
            {
                if (cm.Calculate.Landing == true)
                {
                    if (cm.Land.flaps == 10 || cm.Land.flaps == 15 || cm.Land.flaps == 35)
                    {
                        cm.Land.vga += 20;
                        cm.Land.vapp += 20;
                        cm.Land.vref += 20;
                    }
                }
                if (cm.Calculate.TakeOff == true)
                {
                    cm.TakeOff.v2 += 20;
                    cm.Climb.Vfri5 += 20;
                    cm.Climb.Vfri10 += 20;
                    cm.Climb.Vfri15 += 20;
                    cm.Climb.Vclmb += 20;
                }
            }



            return View();
        }

        // GET: Calculate/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Calculate/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calculate/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}