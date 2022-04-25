using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStudio.Models
{
    public interface ICreditCardRepository
    {
        IEnumerable<CreditCard> CreditCards { get; }
        void SaveCreditCard(CreditCard creditcard);
    }
}
