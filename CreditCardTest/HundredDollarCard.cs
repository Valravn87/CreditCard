using CreditCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTest
{
	class HundredDollarCard : ICard
	{
		public HundredDollarCard(CardTypes type)
		{
			Type = type;
		}

		public CardTypes Type { get; set; }

		public double InterestRate { get { return 0.0; } }

		public double Balance { get; set; }

		public double Interest { get
			{
				switch (Type)
				{
					case CardTypes.Visa:
						return 10.0;
					case CardTypes.MC:
						return 5.0;
					case CardTypes.Discover:
						return 1.0;
					default:
						return 0.0;
				}
			}
		}
	}
}
