using CreditCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTest
{
	public abstract class TestCard : ICard
	{
		public TestCard() { }

		public double InterestRate { get { return 0.0; } }

		public double Balance { get; set; }

		public abstract double Interest { get; }
	}

	public class TestVisaCard : TestCard
	{
		public override double Interest { get { return 10.0; } }
	}

	public class TestMC_Card : TestCard
	{
		public override double Interest { get { return 5.0; } }
	}

	public class TestDiscoverCard : TestCard
	{
		public override double Interest { get { return 1.0; } }
	}
}
