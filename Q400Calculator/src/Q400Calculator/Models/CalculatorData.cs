using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Q400Calculator.Models;

namespace Q400Calculator.Models
{
    public class CalculatorData
    {
        [Display(Name ="Pilots Name")]
        public string Name { get; set; }

        [Display(Name = "Runway Heading")]
        public int Heading { get; set; }

        [Display(Name = "Wind Speed")]
        public int WindSpeed { get; set; }

        [Display(Name = "Trip Distance")]
        public int Distance { get; set; }

        [Display(Name = "Wind Direction")]
        public int WindDirection { get; set; }

        [Display(Name = "Rain")]
        public bool Rain { get; set; }

        [Display(Name = "Snow")]
        public bool Snow { get; set; }

        [Display(Name = "Icing Conditions")]
        public bool Icing { get; set; }

        [Display(Name = "Headwind")]
        public bool Headwind { get; set; }

        [Display(Name = "Tailwind")]
        public bool Tailwind { get; set; }

        [Display(Name = "Landing")]
        public bool Landing { get; set; }

        [Display(Name = "Takeoff")]
        public bool TakeOff { get; set; }


        public CalculatorData()
        {

        }
        public CalculatorData(string name, int heading, int windspeed, int distance, int windDirection,
                                bool rain, bool snow, bool icing, bool headwind, bool tailwind,
                                bool landing, bool takeOff, string direction = "")
        {
            this.Name = name;
            this.Heading = heading;
            this.WindSpeed = windspeed;
            this.WindDirection = windDirection;
            this.Distance = distance;
            this.Rain = rain;
            this.Snow = snow;
            this.Icing = icing;
            this.Headwind = headwind;
            this.Tailwind = tailwind;
            this.Landing = landing;
            this.TakeOff = takeOff;


            do
            {
                if (windDirection <= 44)
                {
                    direction = "N";
                }
                else if (windDirection > 44 && windDirection < 90)
                {
                    direction = "NE";
                }
                else if (windDirection >= 90 && windDirection <= 134)
                {
                    direction = "E";
                }
                else if (windDirection > 134 && windDirection < 180)
                {
                    direction = "SE";
                }
                else if (windDirection >= 180 && windDirection <= 224)
                {
                    direction = "S";
                }
                else if (windDirection > 224 && windDirection < 270)
                {
                    direction = "SW";
                }
                else if (windDirection >= 270 && windDirection <= 314)
                {
                    direction = "W";
                }
                else if (windDirection > 314 && windDirection < 360)
                {
                    direction = "NW";
                }
                else if (windDirection == 360)
                {
                    windDirection = 0;
                }
            } while (direction == "");

        }
    }
}
