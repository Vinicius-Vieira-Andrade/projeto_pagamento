namespace projeto_pagamento
{
    public class Boleto : Pagamento
    {
        Random codigoBarras = new Random();

        Console.WriteLine($" 237.00005636.{codigoBarras.Next(900000000).ToString()}.00052636001");

Console.WriteLine($"{codigoBarras.Next(30000000)}.{codigoBarras.Next(30000000)}");

    }
}