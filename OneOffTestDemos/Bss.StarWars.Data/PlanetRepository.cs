using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bss.StarWars.Entities;

namespace Bss.StarWars.Data
{
    public class PlanetRepository : Bss.StarWars.IPlanetRepository
    {
        public IEnumerable<Planet> GetAllPlanets()
        {
            throw new NotImplementedException();
        }
    }
}
