using System.Collections.Generic;
using Ponto_Digital.Models;

namespace Ponto_Digital.ViewModel
{
    public class ComentariosViewModel
    {
          public List<Comentario> Comentarios {get;set;}        
            public List<Usuario> Usuarios {get;set;}

            public ComentariosViewModel(List<Comentario> comentarios, List<Usuario> usuarios){
                Comentarios = comentarios;
                Usuarios = usuarios;
            }

            public ComentariosViewModel(){
                
            }
    }

}