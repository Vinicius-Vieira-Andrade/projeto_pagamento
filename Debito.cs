using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pagamento
{
    public class Debito : Cartao
    {

        public float Saldo { get; private set; }

        public override void Pagar()
        {
            if (this.Saldo > 0)
            {
                Console.WriteLine($"Você tem saldo suficiente. A compra esta feita.");

            }
            else
            {
                Console.WriteLine($"A compra foi recusada.");
            }
        }
    }
}