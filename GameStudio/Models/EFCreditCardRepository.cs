using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStudio.Models
{
    public class EFCreditCardRepository : ICreditCardRepository
    {

        private ApplicationDbContext context;
        public EFCreditCardRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<CreditCard> CreditCards => context.CreditCards;
        public void SaveCreditCard(CreditCard card)
        {
            context.AttachRange();
            if (card.CreditCardID == 0)
            {
                context.CreditCards.Add(card);
            }
            context.SaveChanges();
        }



    }
}
