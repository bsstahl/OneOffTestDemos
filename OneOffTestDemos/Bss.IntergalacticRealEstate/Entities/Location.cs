using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bss.IntergalacticRealEstate.Entities
{
    public class Location
    {
        public string Name { get; set; }

        public LocationType LocationType { get; set; }

        public double? PopulationDensity { get; set; }

        public Single? Gravity { get; set; }

        public Single? RotationalPeriod { get; set; }

        public Single? OrbitalPeriod { get; set; }

        public IEnumerable<string> ClimateTypes { get; set; }

        public IEnumerable<string> Terrains { get; set; }

        public Single? SurfaceWaterPercentage { get; set; }

    }
}
