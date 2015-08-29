using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHelperExtensions;
using Bss.IntergalacticRealEstate.Entities;

namespace Bss.IntergalacticRealEstate.MLS.Test
{
    public static class LocationExtensions
    {
        public static Location Create(this Location ignored)
        {
            Single? gravity = null;
            if (20.GetRandom() > 0)
                gravity = Convert.ToSingle((1.25).GetRandom(0.75));
            return (null as Location).Create(gravity);
        }

        public static Location Create(this Location ignored, Single? gravity)
        {
            Double? populationDensity = null;
            if (gravity.HasValue)
                if (gravity <= 0.8)
                    populationDensity = 0;
                else if (gravity >= 1.2)
                    populationDensity = 0;
                else
                    populationDensity = (15.0).GetRandom(0.5);

            return (null as Location).Create(gravity, populationDensity);
        }

        public static Location Create(this Location ignored, float? gravity, double? populationDensity)
        {
            return new Location()
            {
                ClimateTypes = new string[] { string.Empty.GetRandom(), string.Empty.GetRandom(), string.Empty.GetRandom() },
                Name = string.Empty.GetRandom(),
                OrbitalPeriod = 400.GetRandom(100),
                RotationalPeriod = 100.GetRandom(10),
                SurfaceWaterPercentage = 80.GetRandom(),
                Terrains = new string[] { string.Empty.GetRandom(), string.Empty.GetRandom() },
                Gravity = gravity,
                PopulationDensity = populationDensity
            };
        }
    }
}
