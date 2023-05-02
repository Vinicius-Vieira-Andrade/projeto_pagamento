namespace projeto_pagamento
{
    public class Boleto : Pagamento
    {
        public string codigoBarras {get; private set;}

        public void Registrar()
        {
            Console.WriteLine($"");
        }
    }
}