using System.Collections.Generic;
using Ponto_Digital.Models;

namespace Ponto_Digital.Interfaces
{
    public interface IUsuario
    {
         Usuario Cadastrar (Usuario usuario);

         List<Usuario> Listar();

         Usuario BuscarPorEmailESenha(string email, string senha);

         Usuario BuscarPorId(int id);
    }
}