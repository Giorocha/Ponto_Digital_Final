using System;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorios {
    public class ClienteRepositorio : BaseRepositorio {
        private const string PATH = "Database/Comum.csv";
        public Usuario ObterPor (string email) {
            if (email != null) {

                foreach (var item in ObterRegistrosCSV (PATH)) {
                    if (email.Equals (ExtrairCampo ("email", item))) {
                        return ConverterEmObjeto (item);
                    }
                }
            }
            return null;
        }

        private Usuario ConverterEmObjeto (string registro) {

            Usuario usuario = new Usuario ();
            System.Console.WriteLine ("REGISTRO:" + registro);
            usuario.Id = int.Parse (ExtrairCampo ("id", registro));
            usuario.NomeCompleto = ExtrairCampo ("nome", registro);
            usuario.Email = ExtrairCampo ("email", registro);
            usuario.DataNascimento = DateTime.Parse (ExtrairCampo ("data_nascimento", registro));
            usuario.Senha = ExtrairCampo ("senha", registro);

            return usuario;
        }
    }
}