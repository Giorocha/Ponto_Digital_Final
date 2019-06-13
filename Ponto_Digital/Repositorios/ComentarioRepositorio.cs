using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorios {
    public class ComentarioRepositorio {
        List<Comentario> listaDeComentarios = new List<Comentario> ();

        public List<Usuario> listaDeUsuarios = new List<Usuario> ();
        private const string PATH = "Database/Comentarios.csv";

        public void CadastrarComentario (Comentario comentario) {

            if (File.Exists (PATH)) {
                comentario.ID = File.ReadAllLines (PATH).Length + 1;
            } else {
                comentario.ID = 1;
            }

            StreamWriter sw = new StreamWriter (PATH, true);

            sw.WriteLine ($"{comentario.ID};{comentario.usuario.NomeCompleto};{comentario.Texto};{DateTime.Now};{comentario.Status}");
            sw.Close ();
        }

        public List<Comentario> ListaDeComentarios () {
            string[] comentarios = File.ReadAllLines (PATH);

            foreach (var item in comentarios) {
                if (item != null) {
                    string[] dados = item.Split (";");
                    System.Console.WriteLine (dados.Length);
                    var comentario = new Comentario ();

                    comentario.ID = int.Parse (dados[0]);
                    comentario.usuario = new Usuario ();
                    comentario.usuario.NomeCompleto = dados[1];
                    comentario.Texto = dados[2];
                    comentario.DataCriacao = DateTime.Parse (dados[3]);
                    comentario.Status = dados[4];

                    listaDeComentarios.Add (comentario);
                    continue;
                }
            }
            return listaDeComentarios;
        }

        public void AprovarComentario(int id){
            string[] linhas = File.ReadAllLines(PATH);
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dadosDaLinha = linhas[i].Split(";");
                if (id.ToString () == dadosDaLinha[0])
                {
                    linhas[i] = ($"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};{dadosDaLinha[3]};{true}");
                    break;
                }
            }
            File.WriteAllLines(PATH, linhas);
            
        }

            public void RejeitaComentario(int id){
            string[] linhas = File.ReadAllLines(PATH);

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dadosDaLinha = linhas[i].Split(";");

                if(id.ToString() == dadosDaLinha[0])
                {
                    linhas[i] = "";
                    break;
                }
            }

            File.WriteAllLines(PATH, linhas);
        }




    }
}