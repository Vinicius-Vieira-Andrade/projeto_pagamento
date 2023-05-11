using System;

namespace projeto_pagamento
{
    public class Debito : Cartao
    {

        public float Saldo { get; private set; } = 20000;

        public override void Pagar()
        {
            if (this.Saldo >= Valor)
            {
                Console.WriteLine($@"
Você tem saldo suficiente.
O valor da compra é de {this.Valor:c2}.");
            }
            else
            {
                Console.WriteLine($"A compra foi recusada. Pois você não possui saldo suficiente.");
            }
        }
    }
}