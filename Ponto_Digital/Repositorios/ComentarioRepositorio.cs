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

                sw.WriteLine($"{comentario.ID};{comentario.usuario.NomeCompleto};{comentario.Texto};{comentario.DataCriacao};{comentario.Status}");
                sw.Close();
            }










        
        //     public List<Comentario> ComentarioCSV (string idNome){

        //     string[] linhas = File.ReadAllLines ("comentarios.csv");

        //     for (int i = linhas.Length - 1; i >= 0; i--)
        //     {
        //         string[] dadosDaLinha = linhas[i].Split(";");
        //         if(string.IsNullOrEmpty(linhas[i])) {
        //             continue;
        //         }

        //         Comentario comentario = new Comentario(
        //             id: int.Parse(dadosDaLinha[0]),
        //             nome: dadosDaLinha[1],
        //             texto: dadosDaLinha[2],
        //             dataCriacao: DateTime.Parse(dadosDaLinha[3]),
        //             status: bool.Parse(dadosDaLinha[4])
        //         );

        //         lsComentarios.Add(comentario);
        //     }
            
        //     return lsComentarios;
        // }

        //      public void Aprova(int id) {
        //     string[] linhas = File.ReadAllLines("comentarios.csv");

        //     for (int i = 0; i < linhas.Length; i++)
        //     {
        //         string[] dadosDaLinha = linhas[i].Split (";");
                
        //         if(id.ToString () == dadosDaLinha[0]) {
        //             linhas[i] = ($"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};{dadosDaLinha[3]};{true}");
        //             break;
        //         }
        //     }
        //     File.WriteAllLines("comentarios.csv",linhas);
        // }

        // public void Rejeita(int id){
        //     string[] linhas = File.ReadAllLines("comentarios.csv");

        //     for (int i = 0; i < linhas.Length; i++)
        //     {
        //         string[] dadosDaLinha = linhas[i].Split(";");

        //         if(id.ToString() == dadosDaLinha[0])
        //         {
        //             linhas[i] = "";
        //             break;
        //         }
        //     }

        //     File.WriteAllLines("comentarios.csv", linhas);
        // }


    }
}