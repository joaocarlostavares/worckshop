using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pedido.entidades.enums
{
    public enum Pedidostatus : int
    {
        pagamento_pendente = 0,
        processando = 1,
        enviado = 2,
        entregado = 3
    }
}