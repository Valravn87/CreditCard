using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static CreditCard.Card;

namespace CreditCard
{
	public interface ICard
	{
		double InterestRate { get; }
		double Balance { get; set; }
		double Interest { get; }
	}
}
