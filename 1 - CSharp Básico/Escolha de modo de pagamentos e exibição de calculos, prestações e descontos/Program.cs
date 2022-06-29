using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto:");
            var valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o código da condição de pagamento:");
            var condicao = Convert.ToDecimal(Console.ReadLine());

            if (condicao == 1)
            {
                decimal valorFinal = valor * 0.90m;
                Console.WriteLine($"Você escolheu pagar o valor de R${valor} à vista ou em cheque, portanto ganhou 10% de desconto e vai pagar apenas R${valorFinal}.");
            }
            else if (condicao == 2)
            {
                decimal valorFinal = valor * 0.95m;
                Console.WriteLine($"Você escolheu pagar o valor de R${valor} à vista com cartão de crédito, portanto ganhou 5% de desconto e vai pagar apenas R${valorFinal}.");
            }
            else if (condicao == 3)
            {
                decimal valorFinal = valor / 2;
                Console.WriteLine($"Você escolheu pagar o valor de R${valor} em duas vezes sem juros e vai pagar duas prestações de R${valorFinal}.");
            }
            else if (condicao == 4)
            {
                decimal valorFinal = (valor * 1.10m) / 3;
                Console.WriteLine($"Você escolheu pagar o valor de R${valor} em 3 vezes, com juros de 10% e vai pagar três prestações de R${valorFinal}.");
            }
            else
            {
                Console.WriteLine($"Código da condição inválido!");
            }
            Console.ReadKey();
        }
    }
}
