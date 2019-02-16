using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
	public interface IWallet
	{
		List<ICard> Cards { get; set; }
		double Interest { get; }
	}
}
