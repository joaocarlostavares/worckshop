using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio9.entities
{
    public class PessoaJuridica : Pessoa
    {
        public int NumeroFunc { get; set; }

        public PessoaJuridica()
        {            
        }

        public PessoaJuridica(string nome, double renda, int numerofunc) : base(nome, renda)
        {
            NumeroFunc = numerofunc;
        }

        public override double imposto()
        {
            if(NumeroFunc > 10)
            {
                return Renda * 0.14;
            }
            else{
                return Renda * 0.16;
            }
        }
    }
}