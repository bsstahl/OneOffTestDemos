using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Linq;

namespace Bss.StarWars.Business.Test
{
    [TestClass]
    public class PlanetLocator_Scout_Should
    {
        [TestMethod]
        public void ReturnAValidCollectionType()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var planetRepository = Db.GetPlanetRepository(mocks);
            var target = new Bss.StarWars.Business.PlanetLocator(planetRepository);
            var actual = target.Scout() as IEnumerable;
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void ReturnAnEmptyCollectionIfNoPlanetsAreKnown()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var planetRepository = Db.GetPlanetRepository(mocks);
            var target = new Bss.StarWars.Business.PlanetLocator(planetRepository);
            var actual = target.Scout();
            Assert.AreEqual(0, actual.Count());
        }
    }
}
