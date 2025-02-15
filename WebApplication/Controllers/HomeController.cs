using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Teclado", Preco = 120.50 },
                new Produto { Id = 2, Nome = "Mouse", Preco = 75.99 },
                new Produto { Id = 3, Nome = "Monitor", Preco = 899.00 }
            };

            return View(produtos);
        }
    }
}
