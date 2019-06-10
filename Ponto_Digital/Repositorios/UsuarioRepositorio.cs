using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorios {
    public class UsuarioRepositorio {
        public List<Usuario> listaDeUsuarios = new List<Usuario>();
        private const string PATH = "Database/Comum.csv";
        public void Inserir (Usuario usuario) {
            if (File.Exists (PATH)) {
                usuario.Id = (ulong) File.ReadAllLines (PATH).Length + 1;
            } else {
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter (PATH, true);

            sw.WriteLine ($"{usuario.Id};{usuario.NomeCompleto};{usuario.Email};{usuario.DataNascimento};{usuario.Senha}");
            sw.Close ();
        }

        public List<Usuario> ListarUsuarios(){
            string[] cadastros = File.ReadAllLines(PATH);

            foreach (var item in cadastros)
            {
                if (item != null)
                {
                    string[] dados = item.Split(";");
                    var usuario = new Usuario();
                    try{
                        
                    usuario.Id = ulong.Parse(dados[0]);
                    }catch(FormatException fe){
                        System.Console.WriteLine("O erro tá aqui");
                    }
                    usuario.NomeCompleto = dados[1];
                    usuario.Email = dados[2];
                    usuario.DataNascimento = DateTime.Parse(dados[3]);
                    usuario.Senha = dados[4];

                    listaDeUsuarios.Add(usuario);
                    continue;
                }
            }
            return listaDeUsuarios;
        }

        


    }
}