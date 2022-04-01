using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Conta
    {
        private string titular = "";
        private double saldo;
        private int numero;

        public string Titular 
        { 
            get{return this.titular;}
            set{this.titular = value;}
        }
         public double Saldo 
        { 
            get{return this.saldo;}
            set{this.saldo = value;}
        }

        public int Numero{
            get{return this.numero;}
            set{this.numero = value; }
        }
        
        public Conta(){
            Numero = 525;
            Saldo  = 6100.00; 
            Titular= "Felipe";
        }
        ~Conta()
        {
            Console.WriteLine("o titular está sendo deletado pelo descontrutor");
        }
        

    }
}