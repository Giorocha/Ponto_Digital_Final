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

        
    }
}