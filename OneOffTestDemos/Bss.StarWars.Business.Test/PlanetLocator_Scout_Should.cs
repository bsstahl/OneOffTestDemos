using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bss.StarWars;
using System.Collections.Generic;
using System.Linq;
using TestHelperExtensions;

namespace Bss.StarWars.Business.Test
{
    [TestClass]
    public class PlanetLocator_Scout_Should
    {
        public TestContext TestContext { get; set; }


        [TestMethod]
        public void ReturnOnlyPlanetsWithGravityGreaterThan95PercentOfStandard()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var db = (null as IPlanetRepository).GetRepository(mocks);

            int planetCount = 100.GetRandom(50);
            var allPlanets = new List<Planet>();
            for (int i = 0; i < planetCount; i++)
                allPlanets.Add((null as Planet).Create());

            TestContext.WriteLine("{0} planets in data store", allPlanets.Count());

            Rhino.Mocks
                .Expect.Call(db.GetAllPlanets())
                .Repeat.Any()
                .Return(allPlanets);

            mocks.ReplayAll();

            var target = new Bss.StarWars.Business.PlanetLocator(db);
            var actual = target.Scout();
            TestContext.WriteLine("{0} planets returned from target", actual.Count());

            foreach (var planet in actual)
                Assert.IsTrue(planet.Gravity > 0.95);

            mocks.VerifyAll();
        }

        [TestMethod]
        public void ReturnOnlyPlanetsWithGravityLessThan105PercentOfStandard()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var db = (null as IPlanetRepository).GetRepository(mocks);

            int planetCount = 100.GetRandom(50);
            var allPlanets = new List<Planet>();
            for (int i = 0; i < planetCount; i++)
                allPlanets.Add((null as Planet).Create());

            TestContext.WriteLine("{0} planets in data store", allPlanets.Count());

            Rhino.Mocks
                .Expect.Call(db.GetAllPlanets())
                .Repeat.Any()
                .Return(allPlanets);

            mocks.ReplayAll();

            var target = new Bss.StarWars.Business.PlanetLocator(db);
            var actual = target.Scout();
            TestContext.WriteLine("{0} planets returned from target", actual.Count());

            foreach (var planet in actual)
                Assert.IsTrue(planet.Gravity < 1.05);

            mocks.VerifyAll();
        }

    }
}
