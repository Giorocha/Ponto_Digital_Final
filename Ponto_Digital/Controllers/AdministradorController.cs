using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Models;
using Ponto_Digital.Repositorios;
using Ponto_Digital.ViewModel;

namespace Ponto_Digital.Controllers


{

    public class AdministradorController : Controller
    {
        ComentarioRepositorio comentario = new ComentarioRepositorio();
        ComentarioRepositorio comentariorepositorio = new ComentarioRepositorio();

        UsuarioRepositorio usuariorepositorio = new UsuarioRepositorio();
        public IActionResult Index(){
            List<Usuario> listadeusuarios = usuariorepositorio.ListarUsuarios();
            var quantidadeDeUsuarios = listadeusuarios.Count();
            ViewData["quantidadeDeUsuarios"] = quantidadeDeUsuarios;

            List<Comentario> listadecomentarios = comentariorepositorio.ListaDeComentarios();
            var quantidadeDeComentarios = listadecomentarios.Count();
            ViewData["quantidadeDeComentarios"] = quantidadeDeComentarios;

            return View();

        }

        public IActionResult Cadastros(){
            ComentariosViewModel usuario = new ComentariosViewModel();
            
            var listarecuperada = usuariorepositorio.ListarUsuarios();

            usuario.Usuarios = listarecuperada;

            return View(usuario);
        }
        public IActionResult Comentarios(){

            ComentariosViewModel comentarios = new ComentariosViewModel();

            var listarecuperada = comentariorepositorio.ListaDeComentarios();

            comentarios.Comentarios = listarecuperada;

            return View(comentarios);
        }

            [HttpGet]
        public IActionResult AprovarComentario(int id){
            comentariorepositorio.AprovarComentario(id);
            return RedirectToAction("Comentarios") ;
        }

        [HttpGet]
        public IActionResult RejeitarComentario(int id){
            comentario.RejeitaComentario(id);
            return RedirectToAction("");
        }
        
    }
}