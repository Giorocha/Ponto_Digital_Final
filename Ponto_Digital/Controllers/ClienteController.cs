using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Ponto_Digital.Models;
using Ponto_Digital.Repositorios;

namespace Ponto_Digital.Controllers
{
    
    public class ClienteController : Controller 
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        AdministradorRepositorio admRepositorio = new AdministradorRepositorio();
        
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
        
        private const string SESSION_ADM = "_ADM";
        
        [HttpGet]
        public IActionResult Login(){
            
            // ViewBag.Nome = "adsa";
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form){
            var usuario = form["email"];
            var senha = form["senha"];

            var cliente = usuarioRepositorio.ListarUsuarios();
            var adm = admRepositorio.Dados();

            foreach (var item in adm)
            {
                if (item!= null && item.EmailAdm.Equals(usuario) && item.SenhaAdm.Equals(senha) )
                {
                    HttpContext.Session.SetString(SESSION_ADM, usuario);
                    HttpContext.Session.SetString(SESSION_CLIENTE, item.NomeAdm);

                    return RedirectToAction("Index", "Administrador");
                }
            }

            foreach (var item in cliente)
            {
                if (item != null && item.Senha.Equals(senha) && item.Email.Equals(usuario))
                {
                    HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                    HttpContext.Session.SetString(SESSION_CLIENTE, item.NomeCompleto);
                }
            }
            ViewData["NomeView"] = "Login";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout(){
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        
    }
}