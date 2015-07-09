using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss.StarWars.Business.Test
{
    internal static class Db
    {
        internal static IPlanetRepository GetPlanetRepository(Rhino.Mocks.MockRepository mocks)
        {
            IPlanetRepository result;
            result = mocks.DynamicMock<IPlanetRepository>();
            return result;
        }
    }
}
