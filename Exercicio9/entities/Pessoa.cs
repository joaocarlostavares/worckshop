using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio9.entities
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }

        public double Renda { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, double renda)
        {
            Nome = nome;
            Renda = renda;    
        }

        public abstract double imposto();
    }
}