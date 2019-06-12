using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Repositorios;
using Ponto_Digital.ViewModel;

namespace Ponto_Digital.Controllers


{

    public class AdministradorController : Controller
    {
        ComentarioRepositorio comentariorepositorio = new ComentarioRepositorio();

        public IActionResult Index(){
            return View();

        }
        public IActionResult Comentarios(){

            ComentariosViewModel comentarios = new ComentariosViewModel();

            var listarecuperada = comentariorepositorio.ListaDeComentarios();

            return View(comentarios);
        }
        
    }
}