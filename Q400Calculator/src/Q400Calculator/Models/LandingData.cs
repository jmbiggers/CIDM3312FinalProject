using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Q400Calculator.Models
{
    public class LandingData
    {

        public int Id { get; set; }

        public int weight { get; set; }

        [Display(Name = "Flaps 5")]
        public int flaps { get; set; }

        [Display(Name = "V Approach Speed")]
        public int vapp { get; set; }

        [Display(Name = "V Ref Speed")]
        public int vref { get; set; }

        [Display(Name = "V Go Around Speed")]
        public int vga { get; set; }
        
        [Display(Name = "OAT above 20c")]
        public bool above20 { get; set; }

        [Display(Name = "OAT")]
        public int OAT { get; set; }

        public LandingData(int weight, int flaps, bool Above20, int oat)
        {
            this.weight = weight;
            this.flaps = flaps;
            this.above20 = Above20;
            this.OAT = oat;
        }
        public LandingData()
        {

        }
    }
}
