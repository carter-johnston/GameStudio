using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStudio.Models
{
    public class CreditCard
    {
        public int CreditCardID { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public string CardExpiration { get; set; }
    }
}
