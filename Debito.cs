using System;

namespace projeto_pagamento
{
    public class Debito : Cartao
    {

        public float Saldo { get; private set; }

        public override void Pagar()
        {
            if (this.Saldo > 0)
            {
                Console.WriteLine($"Você tem saldo suficiente. O  valor da compra é {this.Valor:C2}");

            }
            else
            {
                Console.WriteLine($"A compra foi recusada.");
            }
        }
    }
}