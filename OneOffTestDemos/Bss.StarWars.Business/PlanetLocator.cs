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

        // Finds all planets that meet your
        // minimum standards for residence
        public IEnumerable<Planet> Scout(Species species)
        {
            return _planetRepository.GetAll();
        }

        // Recommends the best planet for you
        public Planet Recommend()
        {
            throw new NotImplementedException();
        }

        internal static int Score(Planet planet)
        {
            throw new NotImplementedException();
        }

        internal static bool MeetsMinimumStandards(Planet planet)
        {
            throw new NotImplementedException();
        }
    }
}
