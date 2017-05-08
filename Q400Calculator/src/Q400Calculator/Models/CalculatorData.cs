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

        public CalculatorData(int heading, int windspeed, int distance, int windDirection,
                                bool rain, bool snow, bool icing, string direction = "")
        {
            this.Heading = heading;
            this.WindSpeed = windspeed;
            this.WindDirection = windDirection;
            this.Distance = distance;
            this.Rain = rain;
            this.Snow = snow;
            this.Icing = icing;


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
