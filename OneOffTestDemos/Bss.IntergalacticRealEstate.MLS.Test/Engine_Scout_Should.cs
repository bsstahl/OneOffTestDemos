using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TestHelperExtensions;
using Bss.IntergalacticRealEstate.Entities;

namespace Bss.IntergalacticRealEstate.MLS.Test
{
    [TestClass]
    public class Engine_Scout_Should
    {
        public TestContext TestContext { get; set; }


        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ThrowAnArgumentNullExceptionIfConstructedWithNullRepository()
        {
            var target = new Engine(null);
            var actual = target.Scout();
        }

        [TestMethod]
        public void ReturnOnlyLocationsWithGravityGreaterThan95PercentOfStandard()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var db = (null as ILocationRepository).Create(mocks);

            int locationCount = 100.GetRandom(50);
            var allLocations = new List<Location>();
            for (int i = 0; i < locationCount; i++)
                allLocations.Add((null as Location).Create());

            TestContext.WriteLine("{0} locations in data store", allLocations.Count());

            Rhino.Mocks
                .Expect.Call(db.GetLocations())
                .Repeat.Any()
                .Return(allLocations);

            mocks.ReplayAll();

            var target = new Engine(db);
            var actual = target.Scout();
            TestContext.WriteLine("{0} locations returned from target", actual.Count());

            foreach (var location in actual)
                Assert.IsTrue(location.Gravity > 0.95);

            mocks.VerifyAll();
        }

        [TestMethod]
        public void ReturnOnlyLocationsWithGravityLessThan105PercentOfStandard()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var db = (null as ILocationRepository).Create(mocks);

            int locationCount = 100.GetRandom(50);
            var allLocations = new List<Location>();
            for (int i = 0; i < locationCount; i++)
                allLocations.Add((null as Location).Create());

            TestContext.WriteLine("{0} locations in data store", allLocations.Count());

            Rhino.Mocks
                .Expect.Call(db.GetLocations())
                .Repeat.Any()
                .Return(allLocations);

            mocks.ReplayAll();

            var target = new Engine(db);
            var actual = target.Scout();
            TestContext.WriteLine("{0} locations returned from target", actual.Count());

            foreach (var location in actual)
                Assert.IsTrue(location.Gravity < 1.05);

            mocks.VerifyAll();
        }

        [TestMethod]
        public void ReturnOnlyLocationsWithPopulationDensityGreaterThanOne()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var db = (null as ILocationRepository).Create(mocks);

            int locationCount = 100.GetRandom(50);
            var allLocations = new List<Location>();
            for (int i = 0; i < locationCount; i++)
                allLocations.Add((null as Location).Create());

            TestContext.WriteLine("{0} locations in data store", allLocations.Count());
            TestContext.WriteLine(allLocations.Print());

            Rhino.Mocks
                .Expect.Call(db.GetLocations())
                .Repeat.Any()
                .Return(allLocations);

            mocks.ReplayAll();

            var target = new Engine(db);
            var actual = target.Scout();
            TestContext.WriteLine("{0} locations returned from target", actual.Count());

            foreach (var location in actual)
                Assert.IsTrue(location.PopulationDensity > 1.0);

            mocks.VerifyAll();
        }

        [TestMethod]
        public void ReturnOnlyLocationsWithPopulationDensityLessThanTwenty()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var db = (null as ILocationRepository).Create(mocks);

            int locationCount = 100.GetRandom(50);
            var allLocations = new List<Location>();
            for (int i = 0; i < locationCount; i++)
                allLocations.Add((null as Location).Create());

            TestContext.WriteLine("{0} locations in data store", allLocations.Count());
            TestContext.WriteLine(allLocations.Print());

            Rhino.Mocks
                .Expect.Call(db.GetLocations())
                .Repeat.Any()
                .Return(allLocations);

            mocks.ReplayAll();

            var target = new Engine(db);
            var actual = target.Scout();
            TestContext.WriteLine("{0} locations returned from target", actual.Count());

            foreach (var location in actual)
                Assert.IsTrue(location.PopulationDensity < 20.0);

            mocks.VerifyAll();
        }

        [TestMethod]
        public void ReturnsAnAcceptableLocationWhenOneIsAvailable()
        {
            var mocks = new Rhino.Mocks.MockRepository();
            var db = (null as ILocationRepository).Create(mocks);

            var allLocations = new List<Location>();
            allLocations.Add((null as Location).Create(1.01f, 6.5));

            TestContext.WriteLine(allLocations.Print());

            Rhino.Mocks
                .Expect.Call(db.GetLocations())
                .Repeat.Any()
                .Return(allLocations);

            mocks.ReplayAll();

            var target = new Engine(db);
            var actual = target.Scout();

            Assert.AreEqual(1, actual.Count());

            mocks.VerifyAll();
        }

    }
}
