
using System;

namespace projeto_pagamento
{
    public class Credito : Cartao
    {
        public float Limite { get; private set;} = 3500f;
        public override void Pagar()
        {
            float resultado;
            float resultado2;

            Console.WriteLine($"Credito selecionado!");
            if (Valor <= Limite)
            {
            volta:
                Console.WriteLine($"Em quantas parcelas você deseja pagar: (Minimo 1 Maximo 12)");
                int parcela = int.Parse(Console.ReadLine()!);

                if (parcela <= 6 && parcela > 0)
                {
                    resultado = Valor * 1.05f;
                    resultado2 = resultado / parcela;
                    Console.WriteLine($"O valor ficará de {resultado.ToString("C", new System.Globalization.CultureInfo("pt-BR"))} e cada parcela ficará {Math.Round(resultado2, 2).ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");
                }
                else if (parcela > 6 && parcela <= 12)
                {
                    resultado = Valor * 1.08f;
                    resultado2 = resultado / parcela;
                    Console.WriteLine($"O valor ficará de {resultado.ToString("C", new System.Globalization.CultureInfo("pt-BR"))} e cada parcela ficará {Math.Round(resultado2, 2).ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");
                    
                }
                else
                {
                    Console.WriteLine($"Por favor insira um número de parcela valido!");
                    goto volta;
                }
            }
            else
            {
                Console.WriteLine($"Seu limite é menor do que o valor da compra.");
            }
        }
    }


}