using System;
using CreditCard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardTest
{
	[TestClass]
	public class PersonTest
	{
		//1 person has 1 wallet and 3 cards(1 Visa, 1 MC 1 Discover) – Each Card has a balance of $100 – 
		//calculate the total interest(simple interest) for this person and per card.
	  [TestMethod]
		public void TestCase1()
		{
			// Arrange
			Person person1 = new Person(new Wallet(
				new HundredDollarCard(CardTypes.Visa),
				new HundredDollarCard(CardTypes.MC),
				new HundredDollarCard(CardTypes.Discover)));

			var expectedCard1 = 10.0;
			var expectedCard2 = 5.0;
			var expectedCard3 = 1.0;
			var expectedPerson1 = 16.0;

			// Act
			var actualCard1 = person1.Wallets[0].Cards[0].Interest;
			var actualCard2 = person1.Wallets[0].Cards[1].Interest;
			var actualCard3 = person1.Wallets[0].Cards[2].Interest;
			var actualPerson1 = person1.TotalInterest;

			// Assert
			Assert.AreEqual(expectedCard1, actualCard1);
			Assert.AreEqual(expectedCard2, actualCard2);
			Assert.AreEqual(expectedCard3, actualCard3);
			Assert.AreEqual(expectedPerson1, actualPerson1);
		}

		//1 person has 2 wallets Wallet 1 has a Visa and Discover , wallet 2 a MC -  
		//each card has $100 balance - calculate the total interest(simple interest) for this person and interest per wallet
		[TestMethod]
		public void TestCase2()
		{
			// Arrange
			Person person1 = new Person(new Wallet(	// Wallet 1
				new HundredDollarCard(CardTypes.Visa),
				new HundredDollarCard(CardTypes.Discover)), 
				new Wallet(	// Wallet 2
					new HundredDollarCard(CardTypes.MC)));

			var expectedWallet1 = 11.0;
			var expectedWallet2 = 5.0;
			var expectedPerson1 = 16.0;

			// Act
			var actualWallet1 = person1.Wallets[0].Interest;
			var actualWallet2 = person1.Wallets[1].Interest;
			var actualPerson1 = person1.TotalInterest;

			// Assert
			Assert.AreEqual(expectedWallet1, actualWallet1);
			Assert.AreEqual(expectedWallet2, actualWallet2);
			Assert.AreEqual(expectedPerson1, actualPerson1);
		}

		//2 people have 1 wallet each, person 1 has 1 wallet , with 2 cards MC and visa person 2 has 1 wallet – 1 visa and 1 MC -  
		//each card has $100 balance - calculate the total interest(simple interest) for each person and interest per wallet
		[TestMethod]
		public void TestCase3()
		{
			// Arrange
			Person person1 = new Person(new Wallet(
				new HundredDollarCard(CardTypes.MC),
				new HundredDollarCard(CardTypes.Visa)));
			Person person2 = new Person(new Wallet(
				new HundredDollarCard(CardTypes.Visa),
				new HundredDollarCard(CardTypes.MC)));

			var expectedPerson1 = 15.0;
			var expectedPerson1Wallet = 15.0;
			var expectedPerson2 = 15.0;
			var expectedPerson2Wallet = 15.0;

			// Act
			var actualPerson1 = person1.TotalInterest;
			var actualPerson1Wallet = person1.Wallets[0].Interest;
			var actualPerson2 = person2.TotalInterest;
			var actualPerson2Wallet = person2.Wallets[0].Interest;

			// Assert
			Assert.AreEqual(expectedPerson1, actualPerson1);
			Assert.AreEqual(expectedPerson1Wallet, actualPerson1Wallet);
			Assert.AreEqual(expectedPerson2, actualPerson2);
			Assert.AreEqual(expectedPerson2Wallet, actualPerson2Wallet);
		}

	}
}
