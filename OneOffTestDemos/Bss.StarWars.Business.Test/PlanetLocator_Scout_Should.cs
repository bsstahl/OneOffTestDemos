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
            var planetRepository = PlanetRepositoryHelper.GetPlanetRepository(mocks);
            Rhino.Mocks.Expect.Call(planetRepository.GetAll()).Return(new List<Planet>());
            mocks.ReplayAll();

            // Act
            var target = new Bss.StarWars.Business.PlanetLocator(planetRepository);
            var actual = target.Scout(SpeciesName.Unknown) as IEnumerable;
            
            // Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void ReturnAnEmptyCollectionIfNoPlanetsAreKnown()
        {
            // Arrange
            var planets = new List<Planet>();
            var mocks = new Rhino.Mocks.MockRepository();
            var planetRepository = PlanetRepositoryHelper.GetPlanetRepository(mocks);
            Rhino.Mocks.Expect.Call(planetRepository.GetAll()).Repeat.Any().Return(planets);
            mocks.ReplayAll();

            // Act
            var target = new Bss.StarWars.Business.PlanetLocator(planetRepository);
            var actual = target.Scout(SpeciesName.Unknown);

            // Assert
            Assert.IsFalse(actual.Any());
        }

        [TestMethod]
        public void OnlyReturnPlanetsWithOneStandardGravityForHumans()
        {
            // Arrange
            var planets = PlanetRepositoryHelper.GetBasicPlanetList();
            var mocks = new Rhino.Mocks.MockRepository();
            var planetRepository = PlanetRepositoryHelper.GetPlanetRepository(mocks);
            Rhino.Mocks.Expect.Call(planetRepository.GetAll()).Repeat.Any().Return(planets);
            mocks.ReplayAll();

            // Act
            var target = new Bss.StarWars.Business.PlanetLocator(planetRepository);
            var actual = target.Scout(SpeciesName.Human);

            // Assert
            Assert.IsFalse(actual.Any(p => !p.GravityTypes.Contains("1 standard")));
        }

    }
}
