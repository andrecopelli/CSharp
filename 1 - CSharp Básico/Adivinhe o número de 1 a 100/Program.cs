using System;

namespace Exemplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int meta = 5;
            int contador = 0;

            while (true)
            {
                
                Console.WriteLine("Vamos ver se você é bom em adivinhar?");
                var numeroAleatorio = new Random().Next(1,100);
                var respostaUsuario = 0;
                
                            
                while (numeroAleatorio != respostaUsuario)
                {
                    Console.WriteLine("Adivinhe um número entre 1 e 100.");
                    respostaUsuario = Convert.ToInt32 (Console.ReadLine());

                    if (numeroAleatorio == respostaUsuario)
                    {
                        Console.WriteLine ("Muito bem, você acertou!");
                    }
                    else if (respostaUsuario > numeroAleatorio)
                    {
                        Console.WriteLine ("Muito alto, preencha um valor menor!");
                    }
                    else
                    {
                        Console.WriteLine ("Muito baixo, preencha um valor maior!");
                    }
                    contador++;
                }
                
                if (contador <= meta)
                {
                    Console.WriteLine ("Chega por hoje.");
                    break;    
                }
                

            }    

        }
    }
}
