using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bss.StarWars;
using Bss.StarWars.Entities;

namespace Bss.IntergalacticRealEstate.MLS
{
    public class PlanetLocator
    {
        const Single _minGravityForScout = 0.95f;
        const Single _maxGravityForScout = 1.05f;
        const int _minPopulationForScout = 10000;

        IPlanetRepository _planetRepository;
        public PlanetLocator(IPlanetRepository planetRepository)
        {
            if (planetRepository == null)
                throw new ArgumentNullException("planetRepository");

            _planetRepository = planetRepository;
        }

        public IEnumerable<Planet> Scout()
        {
            return _planetRepository.GetAllPlanets()
                .Where(p => p.Population.HasValue && p.Population.Value > _minPopulationForScout)
                .Where(p => p.Gravity.HasValue && p.Gravity.Value > _minGravityForScout && p.Gravity.Value < _maxGravityForScout);
        }
    }
}
