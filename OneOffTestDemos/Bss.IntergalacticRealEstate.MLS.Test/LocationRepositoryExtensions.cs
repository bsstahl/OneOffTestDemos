using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bss.IntergalacticRealEstate;

namespace Bss.IntergalacticRealEstate.MLS.Test
{
    public static class LocationRepositoryExtensions
    {
        public static ILocationRepository Create(this ILocationRepository repository)
        {
            var mocks = new Rhino.Mocks.MockRepository();
            return (null as ILocationRepository).Create(mocks);
        }

        public static ILocationRepository Create(this ILocationRepository repository, Rhino.Mocks.MockRepository mockRepository)
        {
            return mockRepository.DynamicMock<ILocationRepository>();
        }
    }
}
