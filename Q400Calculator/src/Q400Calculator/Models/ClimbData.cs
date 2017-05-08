using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Q400Calculator.Models
{
    public class ClimbData
    {
        public int Id { get; set; }

        public int Weight { get; set; }

        [Display (Name = "V FRI Flaps 5")]
        public int Vfri5 { get; set; }

        [Display(Name = "V FRI Flaps 10")]
        public int Vfri10 { get; set; }

        [Display(Name = "V FRI Flaps 15")]
        public int Vfri15 { get; set; }

        [Display(Name = "V Climb")]
        public int Vclmb { get; set; }
        
        public ClimbData( int weight, int vfri5, int vfri10, int vfri15, int vclmb)
        {
            this.Weight = weight;
            this.Vfri5 = vfri5;
            this.Vfri10 = vfri10;
            this.Vfri15 = vfri15;
            this.Vclmb = vclmb;
        }
        public ClimbData()
        {

        }
        
    }
}
