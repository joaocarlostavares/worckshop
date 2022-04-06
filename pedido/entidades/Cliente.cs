using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pedido.entidades
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNasc { get; set; }

        public Cliente()
        {
        }

         public Cliente(string nome, string email, DateTime dataNasc) 
        {
            this.Nome = nome;
            this.Email = email;
            this.DataNasc = dataNasc;
        }
    }
}