using GeoApp.Infrastructure;
using GeoApp.Model;
using GeoApp.Persistence;
using Moq;
using NUnit.Framework;
using System;

namespace GeoApp.Tests
{
    public class UnitTests
    {
        private Mock<IGeoStoreRepository> _mockIGeoStoreRepository;

        [SetUp]
        public void Setup()
        {
            _mockIGeoStoreRepository = new Mock<IGeoStoreRepository>();
            
        }

        [Test]
        public void GetGeoObjectById_Test()
        {
            Guid objGuid = Guid.NewGuid();
            DateTime readObjTime = DateTime.UtcNow;
            var expectedResult = new GeoObject()
            {
                Id = objGuid,
                Accuracy = 0.123d,
                Latitude = 70.12345d,
                Longitude = 70.54321d,
                MeasurementDateTime = readObjTime
            };
            _mockIGeoStoreRepository.Setup(x => x.GetGeoObjectById(objGuid.ToString()))
                .Returns(expectedResult);

            var geoService = new GeoService(_mockIGeoStoreRepository.Object);
            var testResult = geoService.GetObjectById(objGuid.ToString());
            
            Assert.AreEqual(expectedResult, testResult);
        }
    }
}