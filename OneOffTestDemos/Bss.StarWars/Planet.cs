using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss.StarWars
{
    public class Planet
    {
        public string Name { get; set; }
        public int RotationalPeriod { get; set; }
        public int OrbitalPeriod { get; set; }
        public int Diameter { get; set; }
        public IEnumerable<string> ClimateTypes { get; set; }
        public IEnumerable<string> GravityTypes { get; set; }
        public IEnumerable<string> Terrains { get; set;}
        public int? SurfaceWater { get; set; }
        public int Population { get; set;}

        public override string ToString()
        {
            return string.Format("Planet: {0} with {1} gravity", this.Name, string.Join(", ", this.GravityTypes));
        }
    }
}
