using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
	public abstract class Card : ICard
	{
		public Card() { }

		//public Card(double balance)
		//{
		//	Balance = balance;
		//}

		public abstract double InterestRate { get; }

		public double Balance { get; set; }

		public double Interest { get { return Balance * InterestRate; } }
	}

	public class VisaCard : Card
	{
		public VisaCard(double balance)
		{
			Balance = balance;
		}

		public override double InterestRate { get { return 0.10; } }
	}

	public class MC_Card : Card
	{
		public MC_Card(double balance)
		{
			Balance = balance;
		}

		public override double InterestRate { get { return 0.05; } }
	}

	public class DiscoverCard : Card
	{
		public DiscoverCard(double balance)
		{
			Balance = balance;
		}

		public override double InterestRate { get { return 0.01; } }
	}
}
