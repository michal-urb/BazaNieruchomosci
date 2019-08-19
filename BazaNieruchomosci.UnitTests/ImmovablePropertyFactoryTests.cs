using BazaNieruchomosci.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BazaNieruchomosci.UnitTests
{
    [TestClass]
    public class ImmovablePropertyFactoryTests
    {
        [TestMethod]
        public void GetProperty_IsFlat()
        {
            // Arrange
            var propertyFactory = new ImmovablePropertyFactory();
            var property = new ImmovableProperty
            {
                Description = "Mieszkanie o pow. 50 mkw"
            };

            // Act
            var newProperty = propertyFactory.GetProperty(property);

            // Assert
            Assert.IsInstanceOfType(newProperty, typeof(Flat));
        }

        [TestMethod]
        public void GetProperty_IsHouse()
        {
            // Arrange
            var propertyFactory = new ImmovablePropertyFactory();
            var property = new ImmovableProperty
            {
                Description = "Dom o pow. 120 mkw"
            };

            // Act
            var newProperty = propertyFactory.GetProperty(property);

            // Assert
            Assert.IsInstanceOfType(newProperty, typeof(House));
        }

        [TestMethod]
        public void GetProperty_IsCommercialSpace()
        {
            // Arrange
            var propertyFactory = new ImmovablePropertyFactory();
            var property = new ImmovableProperty
            {
                Description = "Lokal biurowy o pow. 100 mkw"
            };

            // Act
            var newProperty = propertyFactory.GetProperty(property);

            // Assert
            Assert.IsInstanceOfType(newProperty, typeof(CommercialSpace));
        }

        [TestMethod]
        public void GetProperty_IsBuildingPlot()
        {
            // Arrange
            var propertyFactory = new ImmovablePropertyFactory();
            var property = new ImmovableProperty
            {
                Description = "Dzia³ka budowlana o pow. 20 arów"
            };

            // Act
            var newProperty = propertyFactory.GetProperty(property);

            // Assert
            Assert.IsInstanceOfType(newProperty, typeof(BuildingPlot));
        }

        [TestMethod]
        public void GetProperty_IsNull()
        {
            // Arrange
            var propertyFactory = new ImmovablePropertyFactory();
            var property = new ImmovableProperty()
            {
                Description = " budowlana o pow. 20 arów"
            };

            // Act
            var newProperty = propertyFactory.GetProperty(property);

            // Assert
            Assert.IsNull(newProperty);
        }
    }
}
