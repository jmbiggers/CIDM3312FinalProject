﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Q400Calculator.Models
{
    public class TakeOffData
    {
        public int Id { get; set; }

        public int weight { get; set; }

        [Display(Name = "Flaps")]
        public int flaps { get; set; }

        [Display(Name = "VR Speed")]
        public int vr { get; set; }

        [Display(Name = "V2 Speed")]
        public int v2 { get; set; }

        [Display(Name = "Altitude")]
        public int altitude { get; set; }

        [Display(Name = "OAT Above 20c")]
        public bool above20 { get; set; }

        [Display(Name = "OAT")]
        public int OAT { get; set; }

        public TakeOffData()
        {

        }

        public TakeOffData(int Weight, int Flaps, int Altitude, int oat, bool Above20, int Vr, int V2)
        {
            this.weight = Weight;
            this.flaps = Flaps;
            this.altitude = Altitude;
            this.OAT = oat;
            this.above20 = Above20;
            this.vr = Vr;
            this.v2 = V2;
        }

    }
}
