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
            var gravityTypes = new List<string>() { "1 standard" };
            return CreatePlanet(gravityTypes);
        }

        internal static Planet CreatePlanetWithNonStandardGravity()
        {
            var gravityTypes = new List<string>() { "1.1 standard" }; // TODO: Change to random
            return CreatePlanet(gravityTypes);
        }

        internal static Planet CreatePlanet(IEnumerable<string> gravityTypes)
        {
            return new Planet()
            {
                Name = Guid.NewGuid().ToString(), // TODO: Change to random
                GravityTypes = gravityTypes
            };
        }
    }
}
