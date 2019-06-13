using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Models;
using Ponto_Digital.Repositorios;

namespace Ponto_Digital.Controllers
{
    public class ComentarioController : Controller
    {
         
        ComentarioRepositorio comentario = new ComentarioRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";

        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        
        public IActionResult Index(){
            return View();
        }

        public IActionResult Comentar(IFormCollection form){

            Comentario comentario = new Comentario();
            
            comentario.usuario = new Usuario();
            
            comentario.usuario.NomeCompleto = HttpContext.Session.GetString(SESSION_CLIENTE);
            comentario.Texto = form["texto"];

            comentarioRepositorio.CadastrarComentario(comentario);
            return RedirectToAction("Index", "Home");
        }

    

        

































        
//         public IComentario comentarioRepositorio {get;set;}

//         public ComentarioController(){
//             comentarioRepositorio = new ComentarioRepositorio();
//         }

//         [HttpGet]
//         public IActionResult adm(){
//             List<Comentario> lsComentarios = comentarioRepositorio.ComentarioCSV(HttpContext.Session.GetString("Nome"));
//             ViewBag.lista = lsComentarios;
//             return View()
// ;        }

//         [HttpPost]
//           public ActionResult adm (IFormCollection form) {
//             Comentario comentarioModel = new Comentario(
//             nome: HttpContext.Session.GetString("idNome"),
//             texto: form["texto"],
//             dataCriacao: DateTime.Now,
//             status: false
//             );

//             comentarioRepositorio.CadastrarComentario (comentarioModel);

//             List<Comentario> lsComentarios = comentarioRepositorio.ComentarioCSV(HttpContext.Session.GetString("idNome"));

//             ViewBag.lista = lsComentarios;
//             return View();
//         }

//          public ActionResult Cadastro(){
//             List<Comentario> lsComentarios = comentarioRepositorio.ComentarioCSV(HttpContext.Session.GetString("idNome"));
//             ViewBag.lista = lsComentarios;
//             return View();
//         }

//         [HttpPost]
//         public ActionResult Cadastro(IFormCollection form) {
//             Comentario comentarioModel = new Comentario(
//                 nome:  HttpContext.Session.GetString ("idNome"),
//                 texto: form["texto"],
//                 dataCriacao: DateTime.Now,
//                 status: false
//             );

//             comentarioRepositorio.CadastrarComentario (comentarioModel);
//             return View();
//         }
//         [HttpGet]
//         public IActionResult Aprova(int id){
//             ComentarioRepositorio comentario = new ComentarioRepositorio();
//             comentario.Aprova(id);
//             return RedirectToAction("Cadastro","Comentario");
//         }

//         [HttpGet]

//         public IActionResult Rejeita(int id){
//              comentarioRepositorio.Rejeita(id);
//             return RedirectToAction("Cadastro","Comentario");
//         }

    }
}