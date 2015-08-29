using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bss.IntergalacticRealEstate;
using Bss.IntergalacticRealEstate.Entities;

namespace Bss.IntergalacticRealEstate.MLS
{
    public class Engine
    {
        const Single _minGravityForScout = 0.95f;
        const Single _maxGravityForScout = 1.05f;
        const double _minPopulationDensityForScout = 1.0;
        const double _maxPopulationDensityForScout = 20.0;

        ILocationRepository _locationRepository;
        public Engine(ILocationRepository locationRepository)
        {
            if (locationRepository == null)
                throw new ArgumentNullException("locationRepository");

            _locationRepository = locationRepository;
        }

        public IEnumerable<Location> Scout()
        {
            return _locationRepository.GetLocations()
                .Where(p => p.PopulationDensity.HasValue && p.PopulationDensity.Value > _minPopulationDensityForScout)
                .Where(p => p.Gravity.HasValue && p.Gravity.Value > _minGravityForScout && p.Gravity.Value < _maxGravityForScout);
        }
    }
}
