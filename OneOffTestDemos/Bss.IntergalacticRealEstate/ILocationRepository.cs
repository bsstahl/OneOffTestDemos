using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss.IntergalacticRealEstate
{
    public interface ILocationRepository
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        IEnumerable<Entities.Location> GetLocations();
    }
}
