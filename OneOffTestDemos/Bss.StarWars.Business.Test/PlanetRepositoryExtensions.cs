using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss.StarWars.Business.Test
{
    public static class PlanetRepositoryExtensions
    {
        public static IPlanetRepository GetRepository(this IPlanetRepository repository)
        {
            var mocks = new Rhino.Mocks.MockRepository();
            return (null as IPlanetRepository).GetRepository(mocks);
        }

        public static IPlanetRepository GetRepository(this IPlanetRepository repository, Rhino.Mocks.MockRepository mockRepository)
        {
            return mockRepository.DynamicMock<IPlanetRepository>();
        }
    }
}
