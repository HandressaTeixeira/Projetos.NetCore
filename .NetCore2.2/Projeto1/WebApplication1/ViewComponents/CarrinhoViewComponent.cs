using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class CarrinhoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var carrinho = new Carrinho()
            {
                TotalItens = 10,
                ValorTotal = 550
            };

            return View(carrinho);
        }
    }
}
