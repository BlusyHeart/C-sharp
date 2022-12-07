namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Linq;

    [TestFixture]
    public class AquariumsTests
    {
        public Fish IFish { get; private set; }

        [TestCase("Peter")]
        [TestCase("Ivan")]
        [TestCase("Mitko")]
        public void NameShouldBeString(string name)
        {
            // Arrange

            Aquarium aquarium = new Aquarium(name, 1);

            // Act

            Assert.True(aquarium.Name != null && aquarium.Name != string.Empty);

        }

        [TestCase("")]
        [TestCase(null)]
        public void NameShouldThrowExceptionIfNullOrEmpty(string name)
        {
            // Act && Assert

            Assert.Throws<ArgumentNullException>(() => new Aquarium(name, 1));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(5)]
        public void CapacityShouldBeZeroOrPositive(int capacity)
        {
            // Arrange

            Aquarium aquarium = new Aquarium("Митко", capacity);

            // Act

            Assert.True(aquarium.Capacity >= 0);
        }

        [TestCase(-1)]
        [TestCase(-5)]
        [TestCase(-10)]
        public void CapacityShouldThrowExceptionIfLessThenZero(int capacity)
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("Ivan", capacity));
        }

        [Test]
        public void AddShouldAddaSingleFish()
        {
            // Arrange
            Fish fish = new Fish("Peter");
            Aquarium aquarium = new Aquarium("SaltWater", 2);
            int actualCount = aquarium.Count;

            // Act
            aquarium.Add(fish);
            int expectedCount = aquarium.Count;

            // Assert

            Assert.AreEqual(expectedCount, actualCount + 1);
        }

        [Test]
        public void AddMethodShouldNotExceedingAquariumCapacity()
        {
            // Arrange

            Fish fish = new Fish("Peter");
            Aquarium aquarium = new Aquarium("SaltWater", 1);
            aquarium.Add(fish);

            // Act && Assert

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(fish));

        }

        [Test]
        public void RemoveFishShouldRemoveASingleFish()
        {
            // Arrange

            Aquarium aquarium = new Aquarium("MicroJumbo", 2);
            Fish hurryBurry = new Fish("Jacky");
            int actualCount = aquarium.Count;

            // Act

            aquarium.Add(hurryBurry);
            aquarium.RemoveFish("Jacky");
            int expectedCount = aquarium.Count;

            // Assert

            Assert.AreEqual(expectedCount, actualCount);

        }

        [Test]
        public void RemoveShouldThrowExceptionIfNullValue()
        {

            // Arrange

            Aquarium aquarium = new Aquarium("MicroJumbo", 2);
            Fish hurryBurry = new Fish("Jacky");
            int actualCount = aquarium.Count;

            // Act && Assert

            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish("Mitko"));
        }

        [Test]
        public void SellFishShouldReturnFish()
        {
            // Arrange
            Aquarium aquarium = new Aquarium("MicroJumbo", 2);
            Fish actualFish = new Fish("Jacky");

            // Act
            aquarium.Add(actualFish);
            Fish expectedFish = aquarium.SellFish("Jacky");

            // Assert
            Assert.AreEqual(expectedFish, actualFish);
            Assert.IsTrue(expectedFish.Available == false);
        }

        [Test]
        public void SellFishShouldThrowExceptionIfNullValue()
        {
            // Arrange
            Aquarium aquarium = new Aquarium("MicroJumbo", 2);
            Fish actualFish = new Fish("Jacky");

            // Act && Assert

            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish(actualFish.Name));

        }
        [Test]
        public void ReportShouldReturnStringResult()
        {
            // Arrange

            Aquarium aquarium = new Aquarium("MicroJumbo", 3);
            Fish actualFish1 = new Fish("Jacky");
            Fish actualFish2 = new Fish("Micky");
            Fish actualFish3 = new Fish("Picky");

            // Act 
            aquarium.Add(actualFish1);
            aquarium.Add(actualFish2);
            aquarium.Add(actualFish3);

            string report = $"Fish available at MicroJumbo: " +
                $"{actualFish1.Name}, {actualFish2.Name}, {actualFish3.Name}";

            // Assert

            Assert.AreEqual(aquarium.Report(), report);
        }
    }
}
