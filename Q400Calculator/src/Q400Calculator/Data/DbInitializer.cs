using Q400Calculator.Models;
using System;
using System.Linq;

namespace Q400Calculator.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.ClimbData.Any())
            {
                return;   // DB has been seeded
            }

            var climbtable = new ClimbData[]
            {
                new ClimbData { Weight = 18000, Vfri5 = 116, Vfri10 = 110, Vfri15 = 107, Vclmb = 130 },
                new ClimbData { Weight = 20000, Vfri5 = 120, Vfri10 = 112, Vfri15 = 109, Vclmb = 131 },
                new ClimbData { Weight = 22000, Vfri5 = 126, Vfri10 = 118, Vfri15 = 115, Vclmb = 137 },
                new ClimbData { Weight = 24000, Vfri5 = 132, Vfri10 = 123, Vfri15 = 120, Vclmb = 143 },
                new ClimbData { Weight = 26000, Vfri5 = 137, Vfri10 = 128, Vfri15 = 125, Vclmb = 148 },
                new ClimbData { Weight = 28000, Vfri5 = 142, Vfri10 = 134, Vfri15 = 130, Vclmb = 154 },
                new ClimbData { Weight = 29000, Vfri5 = 146, Vfri10 = 137, Vfri15 = 133, Vclmb = 158 },

            };
            foreach (ClimbData cd in climbtable)
            {
                context.ClimbData.Add(cd);
            }
            context.SaveChanges();

            //Checking for data in the Take Off Data Table
            if(context.TakeOffData.Any())
            {
                return; // takeoff data has been seeded
            }

            //Seeding the Take Off Data Table
            var takeOffTable = new TakeOffData[]
            {
                // BELOW ////////////////////////////////////////////////////////////////////      
        //Flap 5, altitude 0, below
        new TakeOffData { flaps = 5, weight= 18000, above20 = false, altitude= 0, vr= 102, v2= 116 },
        new TakeOffData { flaps = 5, weight= 20000, above20 = false, altitude= 0, vr= 105, v2= 115 },
        new TakeOffData { flaps = 5, weight= 22000, above20 = false, altitude= 0, vr= 112, v2= 117 },
        new TakeOffData { flaps = 5, weight= 24000, above20 = false, altitude= 0, vr= 118, v2= 122 },
        new TakeOffData { flaps = 5, weight= 26000, above20 = false, altitude= 0, vr= 124, v2= 127 },
        new TakeOffData { flaps = 5, weight= 28000, above20 = false, altitude= 0, vr= 130, v2= 132 },
        new TakeOffData { flaps = 5, weight= 29000, above20 = false, altitude= 0, vr= 133, v2= 135 },

        //Flap 5, altitude 2000, below
        new TakeOffData { flaps = 5, weight= 18000, above20= false, altitude= 2000, vr= 102, v2= 115 },
        new TakeOffData { flaps = 5, weight= 20000, above20= false, altitude= 2000, vr= 106, v2= 114 },
        new TakeOffData { flaps = 5, weight= 22000, above20= false, altitude= 2000, vr= 113, v2= 117 },
        new TakeOffData { flaps = 5, weight= 24000, above20= false, altitude= 2000, vr= 119, v2= 122 },
        new TakeOffData { flaps = 5, weight= 26000, above20= false, altitude= 2000, vr= 125, v2= 127 },
        new TakeOffData { flaps = 5, weight= 28000, above20= false, altitude= 2000, vr= 131, v2= 132 },
        new TakeOffData { flaps = 5, weight= 29000, above20= false, altitude= 2000, vr= 134, v2= 135 },

        //Flap 5, altitude 4000, below
        new TakeOffData { flaps= 5, weight= 18000, above20= false, altitude= 4000, vr= 102, v2= 115 },
        new TakeOffData { flaps= 5, weight= 20000, above20= false, altitude= 4000, vr= 107, v2= 114 },
        new TakeOffData { flaps= 5, weight= 22000, above20= false, altitude= 4000, vr= 113, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= false, altitude= 4000, vr= 120, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= false, altitude= 4000, vr= 126, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= false, altitude= 4000, vr= 131, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= false, altitude= 4000, vr= 135, v2= 135 }, 

        //Flap 5, altitude 6000, below
        new TakeOffData { flaps= 5, weight= 18000, above20= false, altitude= 6000, vr= 102, v2= 115 },
        new TakeOffData { flaps= 5, weight= 20000, above20= false, altitude= 6000, vr= 107, v2= 114 },
        new TakeOffData { flaps= 5, weight= 22000, above20= false, altitude= 6000, vr= 113, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= false, altitude= 6000, vr= 120, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= false, altitude= 6000, vr= 126, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= false, altitude= 6000, vr= 131, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= false, altitude= 6000, vr= 135, v2= 135 },

        //Flap 5, altitude 8000, below
        new TakeOffData { flaps= 5, weight= 18000, above20= false, altitude= 8000, vr= 102, v2= 112 },
        new TakeOffData { flaps= 5, weight= 20000, above20= false, altitude= 8000, vr= 108, v2= 112 },
        new TakeOffData { flaps= 5, weight= 22000, above20= false, altitude= 8000, vr= 115, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= false, altitude= 8000, vr= 121, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= false, altitude= 8000, vr= 127, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= false, altitude= 8000, vr= 133, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= false, altitude= 8000, vr= 137, v2= 135 },

        //Flap 5, altitude 10000, below
        new TakeOffData { flaps= 5, weight= 18000, above20= false, altitude= 10000, vr= 103, v2= 111 },
        new TakeOffData { flaps= 5, weight= 20000, above20= false, altitude= 10000, vr= 110, v2= 111 },
        new TakeOffData { flaps= 5, weight= 22000, above20= false, altitude= 10000, vr= 116, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= false, altitude= 10000, vr= 122, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= false, altitude= 10000, vr= 128, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= false, altitude= 10000, vr= 134, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= false, altitude= 10000, vr= 138, v2= 135 },
        
        // ABOVE ////////////////////////////////////////////////////////////////////
        //Flap 5, altitude 0, above
        new TakeOffData { flaps= 5, weight= 18000, above20= true, altitude= 0, vr= 102, v2= 114 },
        new TakeOffData { flaps= 5, weight= 20000, above20= true, altitude= 0, vr= 107, v2= 113 },
        new TakeOffData { flaps= 5, weight= 22000, above20= true, altitude= 0, vr= 113, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= true, altitude= 0, vr= 120, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= true, altitude= 0, vr= 126, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= true, altitude= 0, vr= 131, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= true, altitude= 0, vr= 135, v2= 135 },
        
        //Flap 5, altitude 2000, above
        new TakeOffData { flaps= 5, weight= 18000, above20= true, altitude= 2000, vr= 102, v2= 113 },
        new TakeOffData { flaps= 5, weight= 20000, above20= true, altitude= 2000, vr= 108, v2= 112 },
        new TakeOffData { flaps= 5, weight= 22000, above20= true, altitude= 2000, vr= 114, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= true, altitude= 2000, vr= 120, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= true, altitude= 2000, vr= 126, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= true, altitude= 2000, vr= 132, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= true, altitude= 2000, vr= 136, v2= 135 },
        
        //Flap 5, altitude 4000, above
        new TakeOffData { flaps= 5, weight= 18000, above20= true, altitude= 4000, vr= 102, v2= 112 },
        new TakeOffData { flaps= 5, weight= 20000, above20= true, altitude= 4000, vr= 108, v2= 112 },
        new TakeOffData { flaps= 5, weight= 22000, above20= true, altitude= 4000, vr= 115, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= true, altitude= 4000, vr= 121, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= true, altitude= 4000, vr= 127, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= true, altitude= 4000, vr= 133, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= true, altitude= 4000, vr= 137, v2= 135 },
        
        //Flap 5, altitude 6000, above
        new TakeOffData { flaps= 5, weight= 18000, above20= true, altitude= 6000, vr= 103, v2= 111 },
        new TakeOffData { flaps= 5, weight= 20000, above20= true, altitude= 6000, vr= 110, v2= 111 },
        new TakeOffData { flaps= 5, weight= 22000, above20= true, altitude= 6000, vr= 116, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= true, altitude= 6000, vr= 122, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= true, altitude= 6000, vr= 128, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= true, altitude= 6000, vr= 134, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= true, altitude= 6000, vr= 138, v2= 135 },
        
        //Flap 5, altitude 8000, above
        new TakeOffData { flaps= 5, weight= 18000, above20= true, altitude= 8000, vr= 103, v2= 110 },
        new TakeOffData { flaps= 5, weight= 20000, above20= true, altitude= 8000, vr= 110, v2= 111 },
        new TakeOffData { flaps= 5, weight= 22000, above20= true, altitude= 8000, vr= 117, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= true, altitude= 8000, vr= 123, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= true, altitude= 8000, vr= 129, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= true, altitude= 8000, vr= 135, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= true, altitude= 8000, vr= 138, v2= 135 },
        
        //Flap 5, altitude 10000, above
        new TakeOffData { flaps= 5, weight= 18000, above20= true, altitude= 10000, vr= 105, v2= 109 },
        new TakeOffData { flaps= 5, weight= 20000, above20= true, altitude= 10000, vr= 112, v2= 111 },
        new TakeOffData { flaps= 5, weight= 22000, above20= true, altitude= 10000, vr= 118, v2= 117 },
        new TakeOffData { flaps= 5, weight= 24000, above20= true, altitude= 10000, vr= 124, v2= 122 },
        new TakeOffData { flaps= 5, weight= 26000, above20= true, altitude= 10000, vr= 130, v2= 127 },
        new TakeOffData { flaps= 5, weight= 28000, above20= true, altitude= 10000, vr= 136, v2= 132 },
        new TakeOffData { flaps= 5, weight= 29000, above20= true, altitude= 10000, vr= 140, v2= 135 },
        
        /////////////////////////////////////////////////////////////////////////////
        //// FLAPS 10 ///////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        
        // BELOW ////////////////////////////////////////////////////////////////////        
        //Flap 10, altitude 0, below
        new TakeOffData { flaps= 10, weight= 18000, above20= false, altitude= 0, vr= 100, v2= 111 },
        new TakeOffData { flaps= 10, weight= 20000, above20= false, altitude= 0, vr= 100, v2= 110 },
        new TakeOffData { flaps= 10, weight= 22000, above20= false, altitude= 0, vr= 103, v2= 109 },
        new TakeOffData { flaps= 10, weight= 24000, above20= false, altitude= 0, vr= 109, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= false, altitude= 0, vr= 115, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= false, altitude= 0, vr= 120, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= false, altitude= 0, vr= 124, v2= 125 },

        //Flap 10, altitude 2000, below
        new TakeOffData { flaps= 10, weight= 18000, above20= false, altitude= 2000, vr= 100, v2= 110 },
        new TakeOffData { flaps= 10, weight= 20000, above20= false, altitude= 2000, vr= 100, v2= 109 },
        new TakeOffData { flaps= 10, weight= 22000, above20= false, altitude= 2000, vr= 105, v2= 109 },
        new TakeOffData { flaps= 10, weight= 24000, above20= false, altitude= 2000, vr= 110, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= false, altitude= 2000, vr= 116, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= false, altitude= 2000, vr= 121, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= false, altitude= 2000, vr= 125, v2= 125 },

        //Flap 10, altitude 4000, below
        new TakeOffData { flaps= 10, weight= 18000, above20= false, altitude= 4000, vr= 100, v2= 110 },
        new TakeOffData { flaps= 10, weight= 20000, above20= false, altitude= 4000, vr= 100, v2= 109 },
        new TakeOffData { flaps= 10, weight= 22000, above20= false, altitude= 4000, vr= 105, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= false, altitude= 4000, vr= 111, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= false, altitude= 4000, vr= 116, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= false, altitude= 4000, vr= 122, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= false, altitude= 4000, vr= 125, v2= 125 }, 

        //Flap 10, altitude 6000, below
        new TakeOffData { flaps= 10, weight= 18000, above20= false, altitude= 6000, vr= 100, v2= 109 },
        new TakeOffData { flaps= 10, weight= 20000, above20= false, altitude= 6000, vr= 100, v2= 108 },
        new TakeOffData { flaps= 10, weight= 22000, above20= false, altitude= 6000, vr= 105, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= false, altitude= 6000, vr= 111, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= false, altitude= 6000, vr= 117, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= false, altitude= 6000, vr= 122, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= false, altitude= 6000, vr= 126, v2= 125 },

        //Flap 10, altitude 8000, below
        new TakeOffData { flaps= 10, weight= 18000, above20= false, altitude= 8000, vr= 100, v2= 108 },
        new TakeOffData { flaps= 10, weight= 20000, above20= false, altitude= 8000, vr= 100, v2= 107 },
        new TakeOffData { flaps= 10, weight= 22000, above20= false, altitude= 8000, vr= 106, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= false, altitude= 8000, vr= 112, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= false, altitude= 8000, vr= 118, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= false, altitude= 8000, vr= 123, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= false, altitude= 8000, vr= 127, v2= 125 },

        //Flap 10, altitude 10000, below
        new TakeOffData { flaps= 10, weight= 18000, above20= false, altitude= 10000, vr= 100, v2= 107 },
        new TakeOffData { flaps= 10, weight= 20000, above20= false, altitude= 10000, vr= 101, v2= 106 },
        new TakeOffData { flaps= 10, weight= 22000, above20= false, altitude= 10000, vr= 108, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= false, altitude= 10000, vr= 113, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= false, altitude= 10000, vr= 119, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= false, altitude= 10000, vr= 124, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= false, altitude= 10000, vr= 128, v2= 125 },
       
        // ABOVE ////////////////////////////////////////////////////////////////////
        //Flap 10, altitude 0, above
        new TakeOffData { flaps= 10, weight= 18000, above20= true, altitude= 0, vr= 100, v2= 109 },
        new TakeOffData { flaps= 10, weight= 20000, above20= true, altitude= 0, vr= 100, v2= 108 },
        new TakeOffData { flaps= 10, weight= 22000, above20= true, altitude= 0, vr= 104, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= true, altitude= 0, vr= 110, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= true, altitude= 0, vr= 116, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= true, altitude= 0, vr= 121, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= true, altitude= 0, vr= 125, v2= 125 },
       
        //Flap 10, altitude 2000, above
        new TakeOffData { flaps= 10, weight= 18000, above20= true, altitude= 2000, vr= 100, v2= 109 },
        new TakeOffData { flaps= 10, weight= 20000, above20= true, altitude= 2000, vr= 100, v2= 108 },
        new TakeOffData { flaps= 10, weight= 22000, above20= true, altitude= 2000, vr= 106, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= true, altitude= 2000, vr= 111, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= true, altitude= 2000, vr= 117, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= true, altitude= 2000, vr= 122, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= true, altitude= 2000, vr= 125, v2= 125 },
        
        //Flap 10, altitude 4000, above
        new TakeOffData { flaps= 10, weight= 18000, above20= true, altitude= 4000, vr= 100, v2= 109 },
        new TakeOffData { flaps= 10, weight= 20000, above20= true, altitude= 4000, vr= 100, v2= 107 },
        new TakeOffData { flaps= 10, weight= 22000, above20= true, altitude= 4000, vr= 106, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= true, altitude= 4000, vr= 112, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= true, altitude= 4000, vr= 117, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= true, altitude= 4000, vr= 123, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= true, altitude= 4000, vr= 126, v2= 125 },
        
        //Flap 10, altitude 6000, above
        new TakeOffData { flaps= 10, weight= 18000, above20= true, altitude= 6000, vr= 100, v2= 107 },
        new TakeOffData { flaps= 10, weight= 20000, above20= true, altitude= 6000, vr= 100, v2= 106 },
        new TakeOffData { flaps= 10, weight= 22000, above20= true, altitude= 6000, vr= 106, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= true, altitude= 6000, vr= 112, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= true, altitude= 6000, vr= 118, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= true, altitude= 6000, vr= 123, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= true, altitude= 6000, vr= 127, v2= 125 },
        
        //Flap 10, altitude 8000, above
        new TakeOffData { flaps= 10, weight= 18000, above20= true, altitude= 8000, vr= 100, v2= 106 },
        new TakeOffData { flaps= 10, weight= 20000, above20= true, altitude= 8000, vr= 100, v2= 105 },
        new TakeOffData { flaps= 10, weight= 22000, above20= true, altitude= 8000, vr= 106, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= true, altitude= 8000, vr= 112, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= true, altitude= 8000, vr= 118, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= true, altitude= 8000, vr= 123, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= true, altitude= 8000, vr= 127, v2= 125 },
       
        //Flap 10, altitude 10000, above
        new TakeOffData { flaps= 10, weight= 18000, above20= true, altitude= 10000, vr= 100, v2= 105 },
        new TakeOffData { flaps= 10, weight= 20000, above20= true, altitude= 10000, vr= 100, v2= 105 },
        new TakeOffData { flaps= 10, weight= 22000, above20= true, altitude= 10000, vr= 106, v2= 108 },
        new TakeOffData { flaps= 10, weight= 24000, above20= true, altitude= 10000, vr= 112, v2= 113 },
        new TakeOffData { flaps= 10, weight= 26000, above20= true, altitude= 10000, vr= 118, v2= 118 },
        new TakeOffData { flaps= 10, weight= 28000, above20= true, altitude= 10000, vr= 123, v2= 122 },
        new TakeOffData { flaps= 10, weight= 29000, above20= true, altitude= 10000, vr= 127, v2= 125 },        
       
        /////////////////////////////////////////////////////////////////////////////
        //// FLAPS 15 ///////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        
        // BELOW ////////////////////////////////////////////////////////////////////        
        //Flap 15, altitude 0, below
        new TakeOffData { flaps= 15, weight= 18000, above20= false, altitude= 0, vr=  98, v2= 106 },
        new TakeOffData { flaps= 15, weight= 20000, above20= false, altitude= 0, vr=  98, v2= 105 },
        new TakeOffData { flaps= 15, weight= 22000, above20= false, altitude= 0, vr= 100, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= false, altitude= 0, vr= 106, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= false, altitude= 0, vr= 111, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= false, altitude= 0, vr= 116, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= false, altitude= 0, vr= 119, v2= 120 },

        //Flap 15, altitude 2000, below
        new TakeOffData { flaps= 15, weight= 18000, above20= false, altitude= 2000, vr=  98, v2= 106 },
        new TakeOffData { flaps= 15, weight= 20000, above20= false, altitude= 2000, vr=  98, v2= 105 },
        new TakeOffData { flaps= 15, weight= 22000, above20= false, altitude= 2000, vr= 101, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= false, altitude= 2000, vr= 106, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= false, altitude= 2000, vr= 112, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= false, altitude= 2000, vr= 117, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= false, altitude= 2000, vr= 120, v2= 120 },

        //Flap 15, altitude 4000, below
        new TakeOffData { flaps= 15, weight= 18000, above20= false, altitude= 4000, vr=  98, v2= 105 },
        new TakeOffData { flaps= 15, weight= 20000, above20= false, altitude= 4000, vr=  98, v2= 104 },
        new TakeOffData { flaps= 15, weight= 22000, above20= false, altitude= 4000, vr= 101, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= false, altitude= 4000, vr= 107, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= false, altitude= 4000, vr= 112, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= false, altitude= 4000, vr= 117, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= false, altitude= 4000, vr= 120, v2= 120 }, 

        //Flap 15, altitude 6000, below
        new TakeOffData { flaps= 15, weight= 18000, above20= false, altitude= 6000, vr=  98, v2= 104 },
        new TakeOffData { flaps= 15, weight= 20000, above20= false, altitude= 6000, vr=  98, v2= 103 },
        new TakeOffData { flaps= 15, weight= 22000, above20= false, altitude= 6000, vr= 102, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= false, altitude= 6000, vr= 108, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= false, altitude= 6000, vr= 113, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= false, altitude= 6000, vr= 118, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= false, altitude= 6000, vr= 121, v2= 120 },

        //Flap 15, altitude 8000, below
        new TakeOffData { flaps= 15, weight= 18000, above20= false, altitude= 8000, vr=  98, v2= 103 },
        new TakeOffData { flaps= 15, weight= 20000, above20= false, altitude= 8000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 22000, above20= false, altitude= 8000, vr= 103, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= false, altitude= 8000, vr= 108, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= false, altitude= 8000, vr= 114, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= false, altitude= 8000, vr= 118, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= false, altitude= 8000, vr= 122, v2= 120 },

        //Flap 15, altitude 10000, below
        new TakeOffData { flaps= 15, weight= 18000, above20= false, altitude= 10000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 20000, above20= false, altitude= 10000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 22000, above20= false, altitude= 10000, vr= 104, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= false, altitude= 10000, vr= 109, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= false, altitude= 10000, vr= 114, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= false, altitude= 10000, vr= 119, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= false, altitude= 10000, vr= 122, v2= 120 },
        
        // ABOVE ////////////////////////////////////////////////////////////////////
        //Flap 15, altitude 0, above
        new TakeOffData { flaps= 15, weight= 18000, above20= true, altitude= 0, vr=  98, v2= 105 },
        new TakeOffData { flaps= 15, weight= 20000, above20= true, altitude= 0, vr=  98, v2= 103 },
        new TakeOffData { flaps= 15, weight= 22000, above20= true, altitude= 0, vr= 101, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= true, altitude= 0, vr= 107, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= true, altitude= 0, vr= 112, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= true, altitude= 0, vr= 117, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= true, altitude= 0, vr= 120, v2= 120 },
        
        //Flap 15, altitude 2000, above
        new TakeOffData { flaps= 15, weight= 18000, above20= true, altitude= 2000, vr=  98, v2= 104 },
        new TakeOffData { flaps= 15, weight= 20000, above20= true, altitude= 2000, vr=  98, v2= 103 },
        new TakeOffData { flaps= 15, weight= 22000, above20= true, altitude= 2000, vr= 102, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= true, altitude= 2000, vr= 108, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= true, altitude= 2000, vr= 113, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= true, altitude= 2000, vr= 118, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= true, altitude= 2000, vr= 121, v2= 120 },
        
        //Flap 15, altitude 4000, above
        new TakeOffData { flaps= 15, weight= 18000, above20= true, altitude= 4000, vr=  98, v2= 103 },
        new TakeOffData { flaps= 15, weight= 20000, above20= true, altitude= 4000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 22000, above20= true, altitude= 4000, vr= 103, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= true, altitude= 4000, vr= 108, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= true, altitude= 4000, vr= 114, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= true, altitude= 4000, vr= 119, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= true, altitude= 4000, vr= 121, v2= 120 },
        
        //Flap 15, altitude 6000, above
        new TakeOffData { flaps= 15, weight= 18000, above20= true, altitude= 6000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 20000, above20= true, altitude= 6000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 22000, above20= true, altitude= 6000, vr= 104, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= true, altitude= 6000, vr= 109, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= true, altitude= 6000, vr= 114, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= true, altitude= 6000, vr= 119, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= true, altitude= 6000, vr= 122, v2= 120 },
        
        //Flap 15, altitude 8000, above
        new TakeOffData { flaps= 15, weight= 18000, above20= true, altitude= 8000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 20000, above20= true, altitude= 8000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 22000, above20= true, altitude= 8000, vr= 104, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= true, altitude= 8000, vr= 110, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= true, altitude= 8000, vr= 115, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= true, altitude= 8000, vr= 120, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= true, altitude= 8000, vr= 123, v2= 120 },
        
        //Flap 15, altitude 10000, above
        new TakeOffData { flaps= 15, weight= 18000, above20= true, altitude= 10000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 20000, above20= true, altitude= 10000, vr=  98, v2= 102 },
        new TakeOffData { flaps= 15, weight= 22000, above20= true, altitude= 10000, vr= 104, v2= 104 },
        new TakeOffData { flaps= 15, weight= 24000, above20= true, altitude= 10000, vr= 110, v2= 109 },
        new TakeOffData { flaps= 15, weight= 26000, above20= true, altitude= 10000, vr= 115, v2= 113 },
        new TakeOffData { flaps= 15, weight= 28000, above20= true, altitude= 10000, vr= 120, v2= 118 },
        new TakeOffData { flaps= 15, weight= 29000, above20= true, altitude= 10000, vr= 123, v2= 120 },

            };
            foreach (TakeOffData tod in takeOffTable)
            {
                context.TakeOffData.Add(tod);
            }
            context.SaveChanges();

            // Checking for data in Landing Data Table
            if (context.LandingData.Any())
            {
                return; // landing data has been seeded
            }

            // Seeding the data for Landing Table
            var landingTable = new LandingData[]
            {
                
        //FLAPS 5
            new LandingData { weight= 18000, flaps= 5, vapp= 115, vref= 115, vga= 109 },
            new LandingData { weight= 20000, flaps= 5, vapp= 120, vref= 120, vga= 110 },
            new LandingData { weight= 22000, flaps= 5, vapp= 126, vref= 126, vga= 115 },
            new LandingData { weight= 24000, flaps= 5, vapp= 131, vref= 131, vga= 120 },
            new LandingData { weight= 26000, flaps= 5, vapp= 137, vref= 137, vga= 125 },
            new LandingData { weight= 28000, flaps= 5, vapp= 142, vref= 142, vga= 130 },
            new LandingData { weight= 29000, flaps= 5, vapp= 146, vref= 146, vga= 134 },
        
        //FLAPS 10
            new LandingData { weight= 18000, flaps= 10, vapp= 109, vref= 108, vga= 108 },
            new LandingData { weight= 20000, flaps= 10, vapp= 112, vref= 112, vga= 108 },
            new LandingData { weight= 22000, flaps= 10, vapp= 117, vref= 117, vga= 108 },
            new LandingData { weight= 24000, flaps= 10, vapp= 122, vref= 122, vga= 112 },
            new LandingData { weight= 26000, flaps= 10, vapp= 127, vref= 127, vga= 117 },
            new LandingData { weight= 28000, flaps= 10, vapp= 132, vref= 132, vga= 122 },
            new LandingData { weight= 29000, flaps= 10, vapp= 136, vref= 136, vga= 125 },
        
        //FLAPS 15
            new LandingData { weight= 18000, flaps= 15, vapp= 106, vref= 105, vga= 105 },
            new LandingData { weight= 20000, flaps= 15, vapp= 106, vref= 106, vga= 105 },
            new LandingData { weight= 22000, flaps= 15, vapp= 112, vref= 112, vga= 105 },
            new LandingData { weight= 24000, flaps= 15, vapp= 117, vref= 117, vga= 107 },
            new LandingData { weight= 26000, flaps= 15, vapp= 122, vref= 121, vga= 111 },
            new LandingData { weight= 28000, flaps= 15, vapp= 126, vref= 126, vga= 116 },
            new LandingData { weight= 29000, flaps= 15, vapp= 129, vref= 129, vga= 119 },
        
        //FLAPS 35
            new LandingData { weight= 18000, flaps= 35, vapp= 101, vref= 101, vga= 101 },
            new LandingData { weight= 20000, flaps= 35, vapp= 102, vref= 102, vga= 102 },
            new LandingData { weight= 22000, flaps= 35, vapp= 107, vref= 107, vga= 107 },
            new LandingData { weight= 24000, flaps= 35, vapp= 112, vref= 112, vga= 112 },
            new LandingData { weight= 26000, flaps= 35, vapp= 116, vref= 116, vga= 116 },
            new LandingData { weight= 28000, flaps= 35, vapp= 120, vref= 120, vga= 120 },
            new LandingData { weight= 29000, flaps= 35, vapp= 123, vref= 123, vga= 123 },
            };

            foreach (LandingData ld in landingTable)
            {
                context.LandingData.Add(ld);
            }
            context.SaveChanges();
        }
    }
}