using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
	public class Wallet : IWallet
	{
		public Wallet(params ICard[] cards)
		{
			Cards = new List<ICard>();
			foreach (var card in cards)
			{
				Cards.Add(card);
			}
		}

		public List<ICard> Cards { get; set; }
		public double Interest { get { return Cards.Sum(x => x.Interest); } }

	}
}
