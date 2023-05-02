using System;

namespace projeto_pagamento
{
    public class Debito : Cartao
    {

        public float Saldo { get; private set; }

        public override void Pagamento()
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