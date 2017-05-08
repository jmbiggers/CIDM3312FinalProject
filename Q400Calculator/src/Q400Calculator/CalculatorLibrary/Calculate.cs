using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q400Calculator.Models;
using Q400Calculator.Models.CalculatorViewModels;
using Q400Calculator.Interfaces;

namespace Q400Calculator.CalculatorLibrary
{
    public class Calculate :  CalculateInterface
    {

        CalculateInterface Calculator { get; }

        public int distance
        {
            get
            {
                return Calculator.distance;
            }

            set
            {
                Calculator.distance = value;
            }
        }

        public int fuel
        {
            get
            {
                return Calculator.fuel;
            }

            set
            {
                Calculator.fuel = value;
            }
        }

        public int heading
        {
            get
            {
                return Calculator.heading;
            }

            set
            {
                Calculator.heading = value;
            }
        }

        public bool headwind
        {
            get
            {
                return Calculator.headwind;
            }

            set
            {
                Calculator.headwind = value;
            }
        }

        public bool icing
        {
            get
            {
                return Calculator.icing;
            }

            set
            {
                Calculator.icing = value;
            }
        }

        public bool rain
        {
            get
            {
                return Calculator.rain;
            }

            set
            {
                Calculator.rain = value;
            }
        }

        public bool snow
        {
            get
            {
                return Calculator.snow;
            }

            set
            {
                Calculator.snow = value;
            }
        }

        public bool tailwind
        {
            get
            {
                return Calculator.tailwind;
            }

            set
            {
                Calculator.tailwind = value;
            }
        }

        public int windDirection
        {
            get
            {
                return Calculator.windDirection;
            }

            set
            {
                Calculator.windDirection = value;
            }
        }

        public int windSpeed
        {
            get
            {
                return Calculator.windSpeed;
            }

            set
            {
                Calculator.windSpeed = value;
            }
        }

        ClimbData Climbing(int weight, int vfri5, int vfri10, int vfri15, int vClmb, bool icing)
        {
            ClimbVewModel Climb = new ClimbVewModel(weight, vfri5, vfri10, vfri15, vClmb);

            if (icing == true)
            {
                vfri5 = vfri5 + 20;
                vfri10 = vfri10 + 20;
                vfri15 = vfri15 + 20;
                vClmb = vClmb + 20;
            }

            return Climb;
        }

        TakeOffData TakeOff(int weight, int flaps, int altitude, bool above20, int heading,
                            int windspeed, int windDirection, int distance, int fuel, int oat,
                            bool rain, bool snow, bool icing, bool headwind, bool tailwind, int vr, int v2)
        {

            TakeoffViewModel takeOff = new TakeoffViewModel(weight, flaps, altitude, above20, heading, windspeed, windDirection, distance, fuel, rain, oat, snow, icing, headwind, tailwind, vr, v2);

            if (rain == true)
            {
                if (above20 == false && oat <= 10 && oat > 0)
                {
                    icing = true;
                }
                else if (above20 == false && oat <= 0)
                {
                    snow = true;
                }
                else if (above20 == false && oat > 10 && oat < 20 && headwind == true)
                {
                    vr = vr - Convert.ToInt32(8 - (.1 * windspeed));
                }
                else if (above20 == false && oat > 10 && oat < 20 && tailwind == true)
                {
                    vr = vr - Convert.ToInt32(8 + (.3 * windspeed));
                }
                else if (above20 == true && headwind == true)
                {
                    vr = vr - Convert.ToInt32(8 - (.1 * windspeed));
                }
                else if (above20 == true && tailwind == true)
                {
                    vr = vr - Convert.ToInt32(8 + (.3 * windspeed));
                }

            }
            if (snow == true)
            {
                if (headwind == true)
                {
                    vr = vr - Convert.ToInt32(8 - (.1 * windspeed));
                }
                else if (tailwind == true)
                {
                    vr = vr - Convert.ToInt32(8 + (.3 * windspeed));
                }

            }
            if (icing == true)
            {
                v2 = v2 + 20;
            }

            if (vr > v2)
            {
                v2 = vr;
            }

            return takeOff;
        }

        LandingData Landing(int weight, int flaps, int altitude, bool above20, int heading,
                            int windspeed, int windDirection, int distance, int fuel, int oat,
                            bool rain, bool snow, bool icing, bool headwind, bool tailwind, int vApp, int vRef, int Vga)
        {
            LandingViewModel land = new LandingViewModel(weight,flaps,heading,windspeed,windDirection,distance,fuel,above20,rain,snow,icing,oat,vApp,vRef,Vga);

            if (rain == true)
            {
                if (above20 == false && oat <= 10)
                {
                    icing = true;
                }
            }
            if (snow == true)
            {

            }
            if (icing == true)
            {
                if (flaps >= 10)
                {
                    vApp = vApp + 20;
                    vRef = vRef + 20;
                    Vga = Vga + 20;
                }
            }


            return land;
        }

    }
}
