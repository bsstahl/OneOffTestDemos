using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bss.IntergalacticRealEstate.Entities;

namespace Bss.IntergalacticRealEstate.MLS.Test
{
    public static class EnumerableLocationExtensions
    {
        public static string Print(this IEnumerable<Location> locations)
        {
            var sb = new StringBuilder();
            foreach (var location in locations)
                sb.AppendLine(string.Format("{0} - Gravity: {1}, Population Density: {2}", location.Name,
                    location.Gravity.HasValue ? location.Gravity.Value.ToString() : "null",
                    location.PopulationDensity.HasValue ? location.PopulationDensity.Value.ToString() : "null"));
            return sb.ToString();
        }
    }
}