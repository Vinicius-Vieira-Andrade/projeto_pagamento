namespace projeto_pagamento
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira { get; set; }
        public string NumeroCartao { get; set; }
        public string Titular { get; set; }
        public string Cvv  { get; set; }

        public abstract void Pagar();

        public string SalvarCartao()
        {
            Console.WriteLine($"Informe a bandeira do cartão");
            this.Bandeira = Console.ReadLine()!;

            Console.WriteLine($"Informe o número do cartão");
            this.NumeroCartao = Console.ReadLine()!;

            Console.WriteLine($"Informe o titular do cartão");
            this.Titular = Console.ReadLine()!;

            Console.WriteLine($"Informe o CVV do cartão");
            this.Cvv = Console.ReadLine()!;
            
            return "Cartão salvo !";

        }
    }
}