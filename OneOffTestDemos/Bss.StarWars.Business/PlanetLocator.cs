using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss.StarWars.Business
{
    public class PlanetLocator
    {
        const Single _minGravityForScout = 0.95f;
        const Single _maxGravityForScout = 1.05f;

        IPlanetRepository _planetRepository;
        public PlanetLocator(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public IEnumerable<Planet> Scout()
        {
            return _planetRepository.GetAllPlanets()
                .Where(p => p.Gravity > _minGravityForScout && p.Gravity < _maxGravityForScout);
        }
    }
}
