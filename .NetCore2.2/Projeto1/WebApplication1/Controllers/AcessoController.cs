using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class AcessoController : Controller
    {
        private readonly WebApplication1Context _context;

        public AcessoController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: Acesso
        public IActionResult Login()
        {
            TempData["IdUsuarioLogado"] = null;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var result = LoginExists(login);

                if (result == null)
                {
                    return NotFound();
                }
                else {

                    TempData["IdUsuarioLogado"] = result.IdUsuario;
                    return RedirectToAction("Index", "Home");
                }

            }
            return View(login);
        }

        public IActionResult RecuperacaoSenha()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RecuperacaoSenha(Login login)
        {
            if (string.IsNullOrWhiteSpace(login.Email))
            {
                return View(login);
            }

            var result = LoginExists(login);
            if (result ==  null)
            {
                return NotFound();
            }

            ViewBag.EmailRecuperacao = "E-mail de recuperação enviado com sucesso";

            return RedirectToAction("Login");
        }
        
        private Usuario LoginExists(Login login)
        {
     
            //if (!string.IsNullOrWhiteSpace(login.Email) && !string.IsNullOrWhiteSpace(login.Senha))
            //    return _context.Usuario.ToList().Find(e => e.Email == login.Email && e.Senha == login.Senha);
            //if (!string.IsNullOrWhiteSpace(login.Email) && string.IsNullOrWhiteSpace(login.Senha))
            //    return _context.Usuario.ToList().Find(e => e.Email == login.Email);

            return null;
        }
    }
}
