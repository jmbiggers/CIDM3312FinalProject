using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q400Calculator.Interfaces;
using Q400Calculator.Models.CalculatorViewModels;

namespace Q400Calculator.Models.CalculatorViewModels
{
    public class PlaneViewModel : CalculateInterface
    {
        CalculateInterface Calculate { get; }

        public LandingViewModel landingViewModel { get; set; }

        public ClimbVewModel climbViewModel { get; set; }

        public TakeoffViewModel takeOffViewModel { get; set; }

        public int heading
        {
            get
            {
                return Calculate.heading;
            }

            set
            {
                Calculate.heading = value;
            }
        }

        public int windSpeed
        {
            get
            {
                return Calculate.windSpeed;
            }

            set
            {
                Calculate.windSpeed = value;
            }
        }

        public int windDirection
        {
            get
            {
                return Calculate.windDirection;
            }

            set
            {
                Calculate.windDirection = value;
            }
        }

        public int distance
        {
            get
            {
                return Calculate.distance;
            }

            set
            {
                Calculate.distance = value;
            }
        }

        public int fuel
        {
            get
            {
                return Calculate.fuel;
            }

            set
            {
                Calculate.fuel = value;
            }
        }

        public bool rain
        {
            get
            {
                return Calculate.rain;
            }

            set
            {
                Calculate.rain = value;
            }
        }

        public bool snow
        {
            get
            {
                return Calculate.snow;
            }

            set
            {
                Calculate.snow = value;
            }
        }

        public bool icing
        {
            get
            {
                return Calculate.icing;
            }

            set
            {
                Calculate.icing = value;
            }
        }

        public bool headwind
        {
            get
            {
                return Calculate.headwind;
            }

            set
            {
                Calculate.headwind = value;
            }
        }

        public bool tailwind
        {
            get
            {
                return Calculate.tailwind;
            }

            set
            {
                Calculate.tailwind = value;
            }
        }
    }
}
