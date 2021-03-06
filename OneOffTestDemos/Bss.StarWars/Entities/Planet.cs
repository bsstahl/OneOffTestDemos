﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss.StarWars.Entities
{
    public class Planet
    {
        public string Name { get; set; }
        public int? RotationalPeriod { get; set; }
        public int? OrbitalPeriod { get; set; }
        public int? Diameter { get; set; }
        public IEnumerable<string> ClimateTypes { get; set; }
        public Single? Gravity{ get; set; }
        public IEnumerable<string> Terrains { get; set;}
        public int? SurfaceWater { get; set; }
        public int? Population { get; set;}
    }
}
