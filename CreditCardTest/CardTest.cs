﻿using System;
using CreditCard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardTest
{
	[TestClass]
	public class CardTest
	{
		[TestMethod]
		public void Test_Interest_VisaCard()
		{
			// Arrange
			Card card = new VisaCard(100);
			double expected = 10;

			// Act
			double actual = card.Interest;

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Test_Interest_MC()
		{
			// Arrange
			Card card = new MC_Card(100);
			double expected = 5;

			// Act
			double actual = card.Interest;

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Test_Interest_Discover()
		{
			// Arrange
			Card card = new DiscoverCard(100);
			double expected = 1;

			// Act
			double actual = card.Interest;

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
