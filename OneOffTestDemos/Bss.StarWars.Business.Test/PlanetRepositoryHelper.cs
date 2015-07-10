using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss.StarWars.Business.Test
{
    internal static class PlanetRepositoryHelper
    {
        internal static IPlanetRepository GetPlanetRepository(Rhino.Mocks.MockRepository mocks)
        {
            IPlanetRepository result;
            result = mocks.DynamicMock<IPlanetRepository>();
            return result;
        }

        internal static IEnumerable<Planet> GetEmptyPlanetList()
        {
            return new List<Planet>();
        }

        internal static IEnumerable<Planet> GetBasicPlanetList()
        {
            var result = new List<Planet>();
            result.Add(CreatePlanetWithNonStandardGravity());
            result.Add(CreatePlanetWithOneStandardGravity());
            result.Add(CreatePlanetWithNonStandardGravity());
            return result;
        }

        internal static Planet CreatePlanetWithOneStandardGravity()
        {
            throw new NotImplementedException();
        }

        internal static Planet CreatePlanetWithNonStandardGravity()
        {
            throw new NotImplementedException();
        }
    }
}
