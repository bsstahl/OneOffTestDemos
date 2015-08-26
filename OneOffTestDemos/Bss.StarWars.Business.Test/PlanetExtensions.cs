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
        public static Planet Create(this Planet ignored)
        {
            Single gravity = Convert.ToSingle((2.0).GetRandom() + 0.5);
            return (null as Planet).Create(gravity);
        }

        public static Planet Create(this Planet ignored, Single gravity)
        {
            int population = 0;
            if ((gravity > 0.8) && (gravity < 1.2))
            {
                var orderOfMagnitude = 4.GetRandom(2);
                population = 10.GetRandom() * (10 ^ orderOfMagnitude);
            }

            return new Planet()
            {
                ClimateTypes = new string[] { string.Empty.GetRandom() },
                Diameter = 100.GetRandom(10),
                Name = string.Empty.GetRandom(),
                OrbitalPeriod = 400.GetRandom(100),
                Population = population,
                RotationalPeriod = 100.GetRandom(10),
                SurfaceWater = null,
                Terrains = new string[] { string.Empty.GetRandom(), string.Empty.GetRandom() },
                Gravity = gravity
            };
        }
    }
}
