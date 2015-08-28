using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHelperExtensions;
using Bss.StarWars.Entities;

namespace Bss.IntergalacticRealEstate.MLS.Test
{
    public static class PlanetExtensions
    {
        public static Planet Create(this Planet ignored)
        {
            Single? gravity = null;
            if (20.GetRandom() > 0)
                gravity = Convert.ToSingle((1.25).GetRandom(0.75));
            return (null as Planet).Create(gravity);
        }

        public static Planet Create(this Planet ignored, Single? gravity)
        {
            int? population = null;
            if (gravity.HasValue)
                if (gravity <= 0.8)
                    population = 0;
                else if (gravity >= 1.2)
                    population = 0;
                else
                {
                    var orderOfMagnitude = 5.GetRandom(2);
                    population = 25.GetRandom() * Convert.ToInt32(Math.Pow(10, orderOfMagnitude));
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
