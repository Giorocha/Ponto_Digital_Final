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
                usuario.Id = File.ReadAllLines (PATH).Length + 1;
            } else {
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter (PATH, true);

            sw.WriteLine ($"{usuario.Id};{usuario.NomeCompleto};{usuario.Email};{usuario.DataNascimento};{usuario.Senha}\n");
            sw.Close ();
        }

        


    }
}