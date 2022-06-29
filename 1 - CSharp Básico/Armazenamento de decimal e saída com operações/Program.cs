using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número decimal: ");
            var numero1 = Console.ReadLine(); //Leitura do número escolhido
            decimal numero1Numerico = Convert.ToDecimal(numero1); //Conversão da variável para decimal

            Console.WriteLine("Digite o segundo número decimal: "); 
            var numero2 = Console.ReadLine(); //Leitura do número escolhido
            decimal numero2Numerico = Convert.ToDecimal(numero2); //Conversão da variável para decimal

            decimal soma = numero1Numerico + numero2Numerico; //Atribuição da soma dos decimais a uma variável
            decimal subtracao = numero1Numerico - numero2Numerico; //Atribuição da subtração dos decimais a uma variável
            decimal multiplicacao = numero1Numerico * numero2Numerico; //Atribuição da multiplicação dos decimais a uma variável
            decimal divisao = numero1Numerico / numero2Numerico; //Atribuição da divisão dos decimais a uma variável

            Console.WriteLine("RESULTADOS:"); //Apresentação dos resultados
            Console.WriteLine($"{numero1Numerico} + {numero2Numerico} = {soma}");
            Console.WriteLine($"{numero1Numerico} - {numero2Numerico} = {subtracao}");
            Console.WriteLine($"{numero1Numerico} x {numero2Numerico} = {multiplicacao}");
            Console.WriteLine($"{numero1Numerico} / {numero2Numerico} = {divisao}");

            Console.ReadKey();
        }
    }
}
