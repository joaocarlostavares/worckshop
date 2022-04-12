using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio10.entities.exeptions
{
    public class DomainExeption : ApplicationException
    {
        public DomainExeption(string message) : base(message)
        {
        }
    }
}