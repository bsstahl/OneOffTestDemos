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
        [TestMethod]
        public void ReturnTheCorrectNumberOfPlanetsWithOneGravity()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var db = (null as IPlanetRepository).GetRepository(mocks);

            var allPlanets = new List<Planet>();
            allPlanets.Add((null as Planet).Create(0.5f));
            allPlanets.Add((null as Planet).Create(1));
            allPlanets.Add((null as Planet).Create(0.9f));
            allPlanets.Add((null as Planet).Create(1));
            allPlanets.Add((null as Planet).Create(1.1f));

            Rhino.Mocks
                .Expect.Call(db.GetAllPlanets())
                .Repeat.Any()
                .Return(allPlanets);

            mocks.ReplayAll();

            var target = new Bss.StarWars.Business.PlanetLocator(db);
            var actual = target.Scout();

            Assert.AreEqual(2, actual.Count());

            mocks.VerifyAll();
        }

        [TestMethod]
        public void ReturnOnlyPlanetsWithGravityGreaterThan95PercentOfStandard()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var db = (null as IPlanetRepository).GetRepository(mocks);

            int planetCount = 100.GetRandom(50);
            var allPlanets = new List<Planet>();
            for (int i = 0; i < planetCount; i++)
                allPlanets.Add((null as Planet).Create());

            Rhino.Mocks
                .Expect.Call(db.GetAllPlanets())
                .Repeat.Any()
                .Return(allPlanets);

            mocks.ReplayAll();

            var target = new Bss.StarWars.Business.PlanetLocator(db);
            var actual = target.Scout();

            foreach (var planet in actual)
                Assert.IsTrue(planet.Gravity > 0.95);

            mocks.VerifyAll();
        }
    }
}
