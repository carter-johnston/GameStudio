using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStudio.Models;


namespace GameStudio.Controllers
{
    public class BillingController : Controller
    {
        private ICreditCardRepository repository; 
       
        public BillingController(ICreditCardRepository repo)
        {
            repository = repo;
        }
        public ViewResult BillingForm() => View(new CreditCard());

        [HttpPost]
        public IActionResult BillingForm(CreditCard card)
        {
            repository.SaveCreditCard(card);
            return RedirectToAction("Index", "Home");
        }
        public ViewResult Completed()
        {   
            return View("Index");
        }

    }
}
