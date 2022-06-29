using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------VAMOS VER SE VOCÊ É BOM NA TABUADA----------");
            
            int resultado = 0;
            int respostaUsuario = 0;
            int respostasCertas = 0;
                
            while (respostasCertas < 10)
            {
                respostasCertas = 0;
                for (int i = 1; i <= 10; i++)
                {
                    int numero1 = new Random().Next(1,10);
                    int numero2 = new Random().Next(1,10);
                    resultado = numero1 * numero2;
                    Console.WriteLine ($"Quanto é {numero1} x {numero2}?");
                    respostaUsuario = Convert.ToInt32 (Console.ReadLine());
                    if (resultado == respostaUsuario)
                    {
                        Console.WriteLine("Você acertou, parabéns!");
                        respostasCertas++;
                    }
                    else
                    {
                        Console.WriteLine ($"Resposta errada, a resposta correta é {resultado}");
                    }
                }
                
                Console.WriteLine ($"Você acertou {respostasCertas} perguntas.");
                
                if (respostasCertas < 10)
                {
                    Console.WriteLine ("Você não acertou todas, vamos jogar de novo.");
                }
                Console.ReadKey();
            }
            
        }
    }
}

