using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
	public class Person
	{
		public Person(params IWallet[] wallets)
		{
			Wallets = new List<IWallet>();
			foreach (var wallet in wallets)
			{
				Wallets.Add(wallet);
			}
		}

		public List<IWallet> Wallets { get; set; }

		public double TotalInterest { get { return Wallets.Sum(x => x.Interest); } }
	}
}
