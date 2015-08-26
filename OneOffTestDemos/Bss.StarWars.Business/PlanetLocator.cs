using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss.StarWars.Business
{
    public class PlanetLocator
    {
        IPlanetRepository _planetRepository;
        public PlanetLocator(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public IEnumerable<Planet> Scout()
        {
            throw new NotImplementedException();
        }
    }
}
