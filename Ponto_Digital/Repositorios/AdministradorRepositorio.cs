using System.Collections.Generic;
using System.IO;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorios
{
    public class AdministradorRepositorio
    {
        public List<Administrador> listaDeAdm = new List<Administrador>();

        private const string PATH = "Database/Administrador.csv";

  
        public List<Administrador> Dados(){
            
            var registros = File.ReadAllLines(PATH);

            foreach (var item in registros)
            {
                var dados = item.Split(";");
                Administrador adm = new Administrador();

                adm.Id = int.Parse(dados[0]);
                adm.NomeAdm = dados[1];
                adm.EmailAdm = dados[2];
                adm.SenhaAdm = dados[3];

                listaDeAdm.Add(adm);
                continue;
            }
            return listaDeAdm;

        }
    }
}