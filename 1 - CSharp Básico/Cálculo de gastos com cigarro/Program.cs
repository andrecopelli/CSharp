using System;

namespace Cálculo_de_gastos_com_cigarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos cigarros você fuma por dia?");
            double cigarrosPorDia = Convert.ToDouble(Console.ReadLine()); //Leitura, conversão e armazenamento da quantidade de cigarros por dia que o usuário consome

            Console.WriteLine("Há quantos anos você fuma?");
            double anosQueFuma = Convert.ToDouble(Console.ReadLine()); //Leitura, conversão e armazenamento da quantidade de anos em que o usuário fuma

            Console.WriteLine("Qual o preço da carteira de cigarro que você fuma?"); 
            double precoDaCarteira = Convert.ToDouble(Console.ReadLine()); //Leitura, conversão e armazenamento do preço do maço de cigarros que o usuário fuma

            Double precoCigarro = precoDaCarteira / 20; //Cálculo e armazenamento do valor unitário do cigarro
            Double custoDiario = cigarrosPorDia * precoCigarro; //Cálculo e armazenamento do custo diário
            Double custoAnual = custoDiario * 365; //Cálculo e armazenamento do custo anual

            Double valorGasto = custoAnual * anosQueFuma; //Cálculo e armazenamento do valor total gasto
            Double cigarrosConsumidosAnual = cigarrosPorDia * 365; //Cálculo e armazenamento da quantidade de cigarros consumida anualmente
            Double totalConsumido = cigarrosConsumidosAnual * anosQueFuma; //Cálculo e armazenamento do total de cigarros consumidos durante a vida do usuário

            Console.WriteLine($"Você gastou R${valorGasto} e consumiu {totalConsumido} cigarros nos {anosQueFuma} anos que fumou."); //Apresentação do resultado concatenada com strings

            Console.ReadKey();
        }
    }
}
