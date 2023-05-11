using System;
using projeto_pagamento;
Boleto b1 = new Boleto();
Credito c1 = new Credito();
Debito d1 = new Debito();
Pagamento p1 = new Pagamento();

//* criar as classes de acordo com o diagrama de classes UML disponibilizado.

// * o programa deve ter um menu com as seguintes opções:
// - pagamento em boleto
// - pagamento em cartão de crédito
// - pagamento em cartão de débito
// - cancelar operação
// - sair do sistema

// * o usuário deve informar o valor da compra.
// * o sistema deverá calcular e exibir o valor a ser pago conforme as regras de negócio
// descrito no diagrama.
Inicio:
Console.WriteLine($@"
    ------------------------------------------
    |        Bem vindo a tela Inicial        |
    |    Para iniciar é necessario colocar   |
    |  o valor do produto que será comprado: |
    ------------------------------------------
");
float valor = float.Parse(Console.ReadLine()!);

bool validacao = true;
do
{
    switch (valor)
    {
        case (> 0):
            Console.WriteLine($"Produto cadastrado!");
            Console.Beep(1000, 500);
            Console.Beep(1000, 600);
        Volta:
            Console.WriteLine($@"
------------------------------------------
|       Qual a forma de pagamento?       |
|                                        |
|  [1] - Pagamento em Boleto             |
|  [2] - Pagamento em Cartão de Crédito  |
|  [3] - Pagamento em Cartão de Débito   |
|  [0] - Cancelar                        |
|                                        |
------------------------------------------
");
            string resposta = Console.ReadLine()!;

            switch (resposta)
            {
                case "1":
                    Console.Beep(1000, 500);
                    Console.WriteLine($@"
Boleto selecionado!
Pagando com boleto você
terá 12% de desconto
    ");
                    b1.Valor = valor;
                    b1.Registrar();
                    validacao = true;
                    break;
                case "2":
                    Console.WriteLine($"Crédito selecionado!");
                    Console.WriteLine($"Selecione a Bandeira do cartão:");
                    c1.Bandeira = Console.ReadLine()!;
                    Console.WriteLine($"Selecione o número do cartão:");
                    c1.NumeroCartao = Console.ReadLine()!;
                    Console.WriteLine($"Selecione o titular do cartão:");
                    c1.Titular = Console.ReadLine()!;
                    Console.WriteLine($"Digite o cvv do cartão:");
                    c1.Cvv = Console.ReadLine()!;
                    Console.Beep(1000, 500);
                    Console.WriteLine();
                    Console.WriteLine($"Bandeira: {c1.Bandeira}");
                    Console.WriteLine($"Número: {c1.NumeroCartao}");
                    Console.WriteLine($"Nome do titular: {c1.Titular}");
                    c1.Valor = valor;
                    c1.Pagar();
                    validacao = true;
                    break;

                case "3":

                    Console.WriteLine($"Débito selecionado");
                    Console.WriteLine($"Selecione a Bandeira do cartão:");
                    d1.Bandeira = Console.ReadLine()!;
                    Console.WriteLine($"Selecione o número do cartão:");
                    d1.NumeroCartao = Console.ReadLine()!;
                    Console.WriteLine($"Selecione o titular do cartão:");
                    d1.Titular = Console.ReadLine()!;
                    Console.WriteLine($"Digite o cvv do cartão:");
                    d1.Cvv = Console.ReadLine()!;

                    Console.Beep(1000, 500);
                    Console.WriteLine($"Bandeira: {d1.Bandeira}");
                    Console.WriteLine($"Número: {d1.NumeroCartao}");
                    Console.WriteLine($"Nome do titular: {d1.Titular}");
                    d1.Valor = valor;
                    d1.Pagar();
                    validacao = true;
                    break;
                case "0":
                    Console.Beep(1000, 500);
                    Console.WriteLine($"Operação cancelada.");
                    p1.Cancelar();
                    validacao = false;
                    break;
                default:
                    Console.Beep(1000, 500);
                    Console.WriteLine($"Por favor insira um valor válido para a escolha.");
                    goto Volta;
            }
            break;
        default:
            Console.WriteLine($"Por favor insira um valor maior do que R$: 0,00.");

            goto Inicio;
    }
} while (validacao == true);