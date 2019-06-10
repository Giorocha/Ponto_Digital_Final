using System.Collections.Generic;
using Ponto_Digital.Models;

namespace Ponto_Digital.Interfaces
{
    public interface IComentario
    {
         void CadastrarComentario (Comentario comentario);

         List<Comentario> ComentarioCSV(string idNome);

         void Aprova(int id);

         void Rejeita(int id);
    }
}