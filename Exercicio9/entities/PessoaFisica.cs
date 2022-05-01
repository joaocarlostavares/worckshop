using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio9.entities
{
    public class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double renda, double gastosaude) : base(nome, renda)
        {
            GastoSaude = gastosaude;
        }
        
        public override double imposto()
        {
            if(Renda < 20000)
            {
                if(GastoSaude > 0){
                    return (Renda * 0.15) - (GastoSaude * 0.5);
                }
                else{
                    return (Renda * 0.15);
                }
            }
            else{
                if(GastoSaude > 0){
                    return (Renda * 0.25) - (GastoSaude * 0.5);
                }
                else{
                    return (Renda * 0.25);
                }
            }
        }
    }
}