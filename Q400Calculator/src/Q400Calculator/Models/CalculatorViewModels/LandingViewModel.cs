using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q400Calculator.Models;
using Q400Calculator.Data;
using Q400Calculator.Interfaces;

namespace Q400Calculator.Models.CalculatorViewModels
{
    public class LandingViewModel : LandingData, CalculateInterface
    {
        CalculateInterface Calculate { get; }

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
        bool CalculateInterface.headwind
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

        bool CalculateInterface.tailwind
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

        public LandingViewModel(int Weight, int Flaps, int Heading, int Windspeed,
                                int Winddirection, int Distance, int Fuel, bool above20,
                                bool Rain, bool Snow, bool Icing, int OAT)
                                :base(Weight, Flaps, above20,  OAT)
        {
            this.heading = Heading;
            this.windSpeed = Windspeed;
            this.windDirection = Winddirection;
            this.distance = Distance;
            this.fuel = Fuel;
            this.rain = Rain;
            this.snow = Snow;
            this.icing = Icing;

            if (Rain == true)
            {
                if(above20 == false && OAT <= 10)
                {
                    Icing = true;
                }
            }
            if (Snow == true)
            {

            }
            if (Icing == true)
            {
                if (flaps >= 10)
                {
                    vapp = vapp + 20;
                    vref = vref + 20;
                    vga = vga + 20;
                }
                else if (flaps == 5)
                {
                    vapp = vapp;
                    vref = vref;
                    vga = vga;
                };
            }

        }


    }
}
