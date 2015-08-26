using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHelperExtensions;

namespace Bss.StarWars.Business.Test
{
    public static class PlanetExtensions
    {
        public static Planet Create(this Planet ignored, string gravityTypes)
        {
            return new Planet()
            {
                ClimateTypes = new string[] { string.Empty.GetRandom() },
                Diameter = 100.GetRandom(10),
                Name = string.Empty.GetRandom(),
                OrbitalPeriod = 400.GetRandom(100),
                Population = Int32.MaxValue.GetRandom(),
                RotationalPeriod = 100.GetRandom(10),
                SurfaceWater = null,
                Terrains = string.Empty.GetRandom(),
                GravityTypes = gravityTypes
            };
        }
    }
}
