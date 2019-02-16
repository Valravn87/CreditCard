using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static CreditCard.Card;

namespace CreditCard
{
	public enum CardTypes { Visa, MC, Discover }

	public interface ICard
	{
		CardTypes Type { get; set; }
		double InterestRate { get; }
		double Balance { get; set; }
		double Interest { get; }
	}
}
