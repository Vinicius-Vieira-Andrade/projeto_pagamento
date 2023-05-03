using System;
namespace projeto_pagamento
{
    public class Boleto : Pagamento
    {
        Random codigoBarras = new Random();

        public void Registrar()
        {
            Console.WriteLine($@" 
----------------------------------------------------------------------------
001 237.00005636.{codigoBarras.Next(900000000).ToString()}.00052636001                                                                   
Valor: {this.Valor * 0.88f:c2}       Dia do Vencimento: {this.DataVencimento}                   
----------------------------------------------------------------------------
");
        }

    }
}