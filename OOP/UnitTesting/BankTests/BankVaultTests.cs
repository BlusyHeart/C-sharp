using NUnit.Framework;
using System;
using System.Linq;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bank;
        private Item item;


        [SetUp]
        public void Setup()
        {
           bank = new BankVault();          
        }

        [Test]
        public void ConstructorShouldHaveNullValues()
        {
            // Arrange
            BankVault bank = new BankVault();

            // Act && Assert

            Assert.That(bank.VaultCells.All(c => c.Value == null));
        }

        [Test]
        public void AddShouldAddToCellNoExistingElement()
        {
            // Arrange

            BankVault bank = new BankVault();
            Item item = new Item("Pesho", "123456");
            Item actualOwner = item;

            // Act

            bank.AddItem("A1", item);
            Item expectedOwner = bank.VaultCells["A1"];

            // Assert

            Assert.AreEqual(expectedOwner, actualOwner);
        }
        [Test]
        public void AddShouldThrowExceptionForNotExistingCell()
        {
            // Arrange
           
            Item item = new Item("Pesho", "123456");           

            // Act && Assert

            Exception ex = Assert.Throws<ArgumentException>(() => bank.AddItem("A", item));

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }
        [Test]
        public void AddShouldThrowExceptionForTakenCell()
        {
            // Arrange

            Item item = new Item("Pesho", "123456");

            // Act && Assert

            bank.AddItem("A1",item);

            Exception ex = Assert.Throws<ArgumentException>(() => bank.AddItem("A1", item));

            Assert.AreEqual(ex.Message, "Cell is already taken!");
        }
        [Test]
        public void AddShouldThrowExceptionIfItemIsAlreadyInTheCell()
        {
            // Arrange
           
            Item item = new Item("Pesho", "123456");

            // Act && Assert

            bank.AddItem("A1", item);

            Exception ex = Assert.Throws<InvalidOperationException>(() => bank.AddItem("A2", item));

            Assert.AreEqual(ex.Message, "Item is already in cell!");
        }

        [Test]
        public void RemoveShouldRemoveExistingElementInACell()
        {
            // Arrange

            Item item = new Item("Pesho", "123456");
            
            // Act
            bank.AddItem("A1", item);
            bank.RemoveItem("A1", item);

            // Assert
            Assert.AreEqual(null, bank.VaultCells["A1"]);
        }

        [Test]
        public void RemoveShouldNotRemoveFromNonExistingCell()
        {
            // Arrange

            Item item = new Item("Pesho", "123456");

            // Act && Assert

            Exception ex = Assert.Throws<ArgumentException>(() => bank.RemoveItem("A", item));

            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
           
        }
        [Test]
        public void RemoveShouldNotRemoveNonExistingItem()
        {
            // Arrange

            Item item = new Item("Pesho", "123456");

            // Act && Assert

            Exception ex = Assert.Throws<ArgumentException>(() => bank.RemoveItem("A1", item));

            Assert.AreEqual(ex.Message, "Item in that cell doesn't exists!");

        }
    }
}