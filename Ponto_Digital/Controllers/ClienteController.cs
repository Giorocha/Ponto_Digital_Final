using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Repositorios;

namespace Ponto_Digital.Controllers
{
    
    public class ClienteController : Controller 
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
        
        [HttpGet]
        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form){
            var usuario = form["email"];
            var senha = form["senha"];
            var cliente = clienteRepositorio.ObterPor(usuario);

            if (cliente != null && cliente.Senha.Equals(senha)){
                HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                HttpContext.Session.SetString(SESSION_CLIENTE, cliente.NomeCompleto);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}