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
                                bool rain, bool snow, bool icing)
        {
            this.Heading = heading;
            this.WindSpeed = windspeed;
            this.WindDirection = windDirection;
            this.Distance = distance;
            this.Rain = rain;
            this.Snow = snow;
            this.Icing = icing;

        }
    }
}
