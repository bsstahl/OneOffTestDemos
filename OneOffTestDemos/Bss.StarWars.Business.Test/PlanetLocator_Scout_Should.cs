using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Rhino.Mocks;

namespace Bss.StarWars.Business.Test
{
    [TestClass]
    public class PlanetLocator_Scout_Should
    {
        [TestMethod]
        public void ReturnAValidCollectionType()
        {
            // Arrange
            var mocks = new Rhino.Mocks.MockRepository();
            var planetRepository = Db.GetPlanetRepository(mocks);
            Rhino.Mocks.Expect.Call(planetRepository.GetAll()).Return(new List<Planet>());
            mocks.ReplayAll();

            // Act
            var target = new Bss.StarWars.Business.PlanetLocator(planetRepository);
            var actual = target.Scout(null) as IEnumerable;
            
            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void ReturnAnEmptyCollectionIfNoPlanetsAreKnown()
        {
            // Arrange
            var planets = new List<Planet>();
            var mocks = new Rhino.Mocks.MockRepository();
            var planetRepository = Db.GetPlanetRepository(mocks);
            Rhino.Mocks.Expect.Call(planetRepository.GetAll()).Repeat.Any().Return(planets);
            mocks.ReplayAll();

            // Act
            var target = new Bss.StarWars.Business.PlanetLocator(planetRepository);
            var actual = target.Scout(null);

            // Assert
            Assert.IsFalse(actual.Any());
        }
    }
}
