using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bss.StarWars;
using System.Collections.Generic;
using System.Linq;

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
            allPlanets.Add((null as Planet).Create("0.5"));
            allPlanets.Add((null as Planet).Create("1"));
            allPlanets.Add((null as Planet).Create("0.7"));
            allPlanets.Add((null as Planet).Create("1"));
            allPlanets.Add((null as Planet).Create("1.1"));

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
    }
}
