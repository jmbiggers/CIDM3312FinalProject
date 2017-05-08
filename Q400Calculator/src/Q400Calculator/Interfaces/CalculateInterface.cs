using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Q400Calculator.Data;
using Q400Calculator.Models;
using Q400Calculator.Models.CalculatorViewModels;

namespace Q400Calculator.Interfaces
{
    public interface CalculateInterface
    {
        [Display(Name = "Runway Heading")]
        int heading { get; set; }

        [Display(Name = "Wind Speed")]
        int windSpeed { get; set; }

        [Display(Name = "Wind Direction")]
        int windDirection { get; set; }

        [Display(Name = "Trip Distance")]
        int distance { get; set; }

        [Display(Name = "Fuel Ammount")]
        int fuel { get; set; }

        [Display(Name = "Rain")]
        bool rain { get; set; }

        [Display(Name = "Snow")]
        bool snow { get; set; }

        [Display(Name = "Icing Conditions")]
        bool icing { get; set; }

        [Display(Name = "Headwind")]
        bool headwind { get; set; }

        [Display(Name = "Tailwind")]
        bool tailwind { get; set; }
    }
}
