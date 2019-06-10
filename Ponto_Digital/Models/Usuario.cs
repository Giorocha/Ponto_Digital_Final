using System;

namespace Ponto_Digital.Models
{
    public class Usuario
    {
        public ulong Id{get;set;}
        public string NomeCompleto {get;set;}
        public string Email{get;set;}

        public string Senha{get;set;}

        public DateTime DataNascimento{get;set;}

        public bool Administrador {get;set;}

    }
}