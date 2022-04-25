using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStudio.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStudio.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IProductRepository repository;

        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
