using System;

namespace Projeto5
{
    public static class AcoesDoSistema
    {
        private static Fila _fila = new Fila();

        public static void Enfileirar()
        {
            System.Console.WriteLine("Insira o valor que gostaria de enfileirar:");
            int valorParaEnfileirar = Convert.ToInt32(System.Console.ReadLine());

            _fila.Enfileirar(valorParaEnfileirar);

            ImprimirQuantidade();
        }

        public static void Desenfileirar()
        {
            var itemDesenfileirado = _fila.Desenfileirar();
            System.Console.WriteLine($"O item desenfileirado foi {itemDesenfileirado}.");
            ImprimirQuantidade();
        }

        public static void VerPrimeiro()
        {
            if (_fila.Quantidade == 0)
            {
                System.Console.WriteLine("A fila está vazia.");
            }
            else
            {
                System.Console.WriteLine($"O item que está em primeiro na fila é {_fila.Primeiro}.");
            }
        }

        public static void VerificarSeExiste()
        {
            System.Console.WriteLine("Digite o item que gostaria de verificar: ");
            var itemParaVerificar = Convert.ToInt32(Console.ReadLine());
            var existe = _fila.VerificarSeExiste(itemParaVerificar);

            if (existe)
            {
                System.Console.WriteLine($"O item {itemParaVerificar} existe na fila.");
            }
            else
            {
                System.Console.WriteLine($"O item {itemParaVerificar} não existe na fila.");
            }
        }

        public static void LimpaFila()
        {
            _fila.LimpaFila();
            ImprimirQuantidade();
        }

        public static void ChamaMenu()
        {
            _fila.ChamaMenu();
        }

        public static void ImprimirQuantidade()
        {
            System.Console.WriteLine($"O tamanho da fila ficou {_fila.Quantidade}.");
        }
    }
}