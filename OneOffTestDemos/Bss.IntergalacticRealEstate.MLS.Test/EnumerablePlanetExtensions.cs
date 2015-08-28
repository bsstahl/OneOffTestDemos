using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bss.StarWars.Entities;

namespace Bss.IntergalacticRealEstate.MLS.Test
{
    public static class EnumerablePlanetExtensions
    {
        public static string Print(this IEnumerable<Planet> planets)
        {
            var sb = new StringBuilder();
            foreach (var planet in planets)
                sb.AppendLine(string.Format("{0} - Gravity: {1}, Population: {2}", planet.Name,
                    planet.Gravity.HasValue ? planet.Gravity.Value.ToString() : "null",
                    planet.Population.HasValue ? planet.Population.Value.ToString() : "null"));
            return sb.ToString();
        }
    }
}