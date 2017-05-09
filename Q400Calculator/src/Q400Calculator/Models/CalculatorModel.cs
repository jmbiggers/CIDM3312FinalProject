using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q400Calculator.Models
{
    public class CalculatorModel
    {

        public LandingData Land { get; set; }
        public TakeOffData TakeOff { get; set; }
        public ClimbData Climb { get; set; }
        public CalculatorData Calculate { get; set; }

    }
}
