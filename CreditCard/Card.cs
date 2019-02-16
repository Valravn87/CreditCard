using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
	public class Card : ICard
	{
		public Card(CardTypes type, double balance)
		{
			Type = type;
			Balance = balance;
		}

		public CardTypes Type { get; set; }

		public double InterestRate
		{
			get
			{
				switch (Type)
				{
					case CardTypes.Visa:
						return 0.10;
					case CardTypes.MC:
						return 0.05;
					case CardTypes.Discover:
						return 0.01;
					default:
						return 0.00;
				}
			}
		}

		public double Balance { get; set; }

		public double Interest { get { return Balance * InterestRate; } }
	}
}
