using System;

namespace Ponto_Digital.Models
{
    public class Comentario
    {
        public Usuario usuario {get;set;}

        public string Texto {get;set;}

        public DateTime DataCriacao {get;set;}

        public int ID{get;set;}
        
        public bool Status{get;set;}
        public string Nome{get;set;}

        public Comentario (string nome, string texto, DateTime dataCriacao, bool status){
            this.Nome = nome;
            this.Texto = texto;
            this.DataCriacao = dataCriacao;
            this.Status = status;
        }

         public Comentario (int id, string nome,string texto, DateTime dataCriacao,bool status)
        {
            this.ID = id;
            this.Nome = nome;
            this.Texto = texto;
            this.DataCriacao = dataCriacao;
            this.Status = status;
        }
    }
}