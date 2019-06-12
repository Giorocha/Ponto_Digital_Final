using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorios
{
    public class ComentarioRepositorio 
    {
            List<Comentario> listaDeComentarios = new List<Comentario> ();

            public List<Usuario> listaDeUsuarios = new List<Usuario>();
            private const string PATH = "Database/Comentarios.csv";

            public void CadastrarComentario(Comentario comentario){
                
                
                if (File.Exists(PATH))
                {
                    comentario.ID = File.ReadAllLines(PATH).Length +1;
                }else{
                    comentario.ID = 1;
                }
                
                StreamWriter sw = new StreamWriter(PATH, true);

                sw.WriteLine($"{comentario.ID};{comentario.usuario.NomeCompleto};{comentario.Texto};{DateTime.Now};{comentario.Status}");
                sw.Close();
            }      

            public List<Comentario> ListaDeComentarios()
       {
           string[] comentarios = File.ReadAllLines(PATH);

           foreach (var item in comentarios)
           {
               if (item != null)
               {
                   string[] dados = item.Split(";");
                   var comentario = new Comentario();

                       comentario.ID = int.Parse(dados[0]);
                       comentario.usuario.NomeCompleto = dados[1];
                       comentario.Texto = dados[2];
                       comentario.DataCriacao = DateTime.Parse(dados[3]);
                       comentario.Status = dados[4];

                       listaDeComentarios.Add(comentario);
                   continue;
               }
           }
           return listaDeComentarios;
       }
    }
}