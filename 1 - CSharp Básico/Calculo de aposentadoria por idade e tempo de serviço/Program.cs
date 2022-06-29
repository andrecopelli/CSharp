using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você tem?");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantos anos você trabalhou?");
            int tempoLaboral = Convert.ToInt32(Console.ReadLine());

            if (idade >= 65)
            {
                Console.WriteLine("Você pode se aposentar por idade.");
            }
            else if (tempoLaboral >= 30)
            {
                Console.WriteLine("Você pode se aposentar por tempo de serviço.");
            }
            else if (idade >= 60 && tempoLaboral >= 25)
            {
                Console.WriteLine("Você pode se aposentar por tempo de serviço e idade.");
            }
            else
            {
                Console.WriteLine("Infelizmente você ainda não pode se aposentar.");
            }
            Console.ReadKey();
        }
    }
}