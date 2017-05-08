using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q400Calculator.Models;
using Q400Calculator.Data;
using Q400Calculator.Models.CalculatorViewModels;
using Q400Calculator.Interfaces;

namespace Q400Calculator.Models.CalculatorViewModels
{
    public class TakeoffViewModel : TakeOffData, CalculateInterface
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

        public TakeoffViewModel(int Weight, int Flaps, int Altitude, bool Above20,
                                int Heading, int Windspeed, int Winddirection,
                                int Distance, int Fuel, bool Rain, int OAT,
                                bool Snow, bool Icing, bool Headwind, bool Tailwind)
                                :base(Weight, Flaps, Altitude, OAT, Above20 )
        {

            this.weight = Weight;
            this.flaps = Flaps;
            this.altitude = Altitude;
            this.above20 = Above20;
            this.heading = Heading;
            this.windSpeed = Windspeed;
            this.windDirection = Winddirection;
            this.distance = Distance;
            this.fuel = Fuel;
            this.rain = Rain;
            this.snow = Snow;
            this.icing = Icing;
            this.OAT = OAT;
            this.headwind = Headwind;
            this.tailwind = Tailwind;


            if(Rain == true)
            {
                if (Above20 == false && OAT <= 10 && OAT > 0)
                {
                    Icing = true;
                }
                else if (Above20 == false && OAT  <= 0)
                {
                    Snow = true;
                }
                else if (above20 == false && OAT > 10 && OAT < 20 && Headwind == true)
                {
                    vr = vr - Convert.ToInt32(8 - (.1 * Windspeed));
                }
                else if (above20 == false && OAT > 10 && OAT < 20 && Tailwind == true)
                {
                    vr = vr - Convert.ToInt32(8 + (.3 * Windspeed));
                }
                else if (above20 == true && Headwind == true)
                {
                    vr = vr - Convert.ToInt32(8 - (.1 * Windspeed));
                }
                else if (above20 == true && Tailwind == true)
                {
                    vr = vr - Convert.ToInt32(8 + (.3 * Windspeed));
                }

            }
            if (Snow == true)
            {
                if (Headwind == true)
                {
                    vr = vr - Convert.ToInt32(8 - (.1 * Windspeed));
                }
                else if (Tailwind == true)
                {
                    vr = vr - Convert.ToInt32(8 + (.3 * Windspeed));
                }

            }
            if (Icing == true)
            {
                v2 = v2 + 20;
            }

            if (vr > v2)
            {
                v2 = vr;
            }
        }


    }
}
