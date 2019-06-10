using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Models;
using Ponto_Digital.Repositorios;

namespace Ponto_Digital.Controllers
{
    public class CadastroController : Controller
    {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        [HttpGet]
        public IActionResult Index(){
            ViewData["NomeView"] = "Cadastro";
            return View();

        }

        [HttpPost]
        public IActionResult CadastrarUsuario (IFormCollection form){
            Usuario usuario = new Usuario();

            usuario.NomeCompleto = form["nome"];
            usuario.Email = form["email"];
            usuario.DataNascimento = DateTime.Parse(form["data-nascimento"]);
            usuario.Senha = form["senha"];

            usuarioRepositorio.Inserir(usuario);

            ViewBag.Mensagem = "Cadastrado";

            ViewData["Action"] = "Cadastro";
            return RedirectToAction("Index", "Home");
        }
    }
}