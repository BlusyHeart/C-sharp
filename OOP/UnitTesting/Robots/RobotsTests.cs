namespace Robots.Tests
{
    using Microsoft.VisualBasic;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    

    [TestFixture]
    public class RobotsTests
    {
        [TestCase(20)]
        [TestCase(1)]
        [TestCase(0)]
        public void CapacityShouldBePositiveNumber(int capacity)
        {            
            RobotManager robotManager = new RobotManager(capacity);

            Assert.That(robotManager.Capacity, Is.GreaterThanOrEqualTo(0));
        }

        [TestCase(-1)]
        [TestCase(-15)]
        [TestCase(-45)]
        public void CapacityShouldThrowExceptionForNegativeNumber(int capacity)
        {          
            Assert.Throws<ArgumentException>(() => new RobotManager(capacity), "Invalid capacity!");
        }

        [Test]
        public void AddShouldAddRobot()
        {
            // Arrange

            RobotManager robotManager = new RobotManager(20);
            Robot robot = new Robot("Pavel", 20);
           
            // Act

            robotManager.Add(robot);

            // Assert

            Assert.AreEqual(1, robotManager.Count);
            
        }

        [Test]
        public void AddShouldThrowExceptionForExistingElement()
        {

            // Arrange

            RobotManager robotManager = new RobotManager(20);
            Robot robot = new Robot("Pavel", 20);

            // Act

            robotManager.Add(robot);

            // Assert

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));
        }
        [Test]
        public void AddShouldThrowExceptionForNotEnoughCapacity()
        {
            // Arrange

            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Pavel", 20);

            // Act

            robotManager.Add(robot);

            // Assert

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(new Robot("Gosho", 30)));
        }

        [Test]
        public void RemoveShouldRemoveAnElement()
        {
            // Arrange

            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Pavel", 20);

            // Act

            robotManager.Add(robot);
            robotManager.Remove(robot.Name);

            // Assert

            Assert.AreEqual(0, robotManager.Count);
        }

        [Test]
        public void RemoveShouldThrowExceptionForNotExistingElement()
        {

            // Arrange

            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Pavel", 20);

            // Act

            robotManager.Add(robot);           

            // Assert

            Assert.Throws<InvalidOperationException>(() => robotManager.Remove("Krasi"));
        }

        [Test]
        public void WorkShouldLowBattery()
        {
            // Arrange

            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Pavel", 20);

            // Act

            robotManager.Add(robot);
            robotManager.Work(robot.Name,"dsd", 16);

            // Assert

            Assert.AreEqual(4, robot.Battery);
        }

        [Test]
        public void WorkShouldThrowExceptionForNoExistingElement()
        {
            // Arrange

            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Pavel", 20);

            // Act

            robotManager.Add(robot);

            // Assert

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Krasio","dsada", 16));
        }
        [Test]
        public void WorkShouldThrowExceptionForBiggerBateryUsage()
        {
            // Arrange

            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Pavel", 20);

            // Act

            robotManager.Add(robot);

            // Assert

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Pavel","dsadas", 25));
        }

        [Test]
        public void ChargeShouldRechargeFullBattery()
        {
            // Arrange

            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Pavel", 20);

            // Act

            robotManager.Add(robot);
            robotManager.Work(robot.Name,"dasdasd", 17);
            robotManager.Charge(robot.Name);

            // Assert

            Assert.AreEqual(20, robot.MaximumBattery);
        }

        [Test]
        public void ChargeShouldThrowExceptionForNoExistingElement()
        {
            // Arrange

            RobotManager robotManager = new RobotManager(1);
            Robot robot = new Robot("Pavel", 20);

            // Act

            robotManager.Add(robot);
            robotManager.Work(robot.Name,"dasdasd", 17);

            // Assert

            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("Krasio"));
        }
    }
}
