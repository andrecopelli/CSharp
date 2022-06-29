using System;

namespace Projeto5
{
    public class Fila
    {
        private int[] _fila;

        public int Quantidade
        {
            get
            {
                return _fila.Length;            
            }
        }

        public int Primeiro
        {
            get {return _fila[0];}
        }

        public Fila()
        {
            _fila = new int[0];
        }

        public void Enfileirar(int itemParaEnfileirar)
        {
            var quantidade = Quantidade;

            quantidade++;
            var novoArray = new int[quantidade];

            for (int i = 0; i < _fila.Length; i++)
            {
                novoArray[i] = _fila[i];
            }

            _fila = novoArray;
            _fila[quantidade - 1] = itemParaEnfileirar;
        }

        public int Desenfileirar()
        {
            var itemDesenfileirado = _fila[0];
            var filaTemporaria = new int[_fila.Length - 1];

            for (int i = 0; i < filaTemporaria.Length; i++)
            {
                filaTemporaria[i] = _fila[i + 1];
            }

            _fila = filaTemporaria;
            return itemDesenfileirado;
        }

       public void LimpaFila()
       {
           _fila = new int[0];
       }

       public bool VerificarSeExiste(int itemParaVerificar)
       {
           
           foreach (var item in _fila)
           {
               if (item == itemParaVerificar)
               {
                   return true;
               }
           }

           return false;
       }

       public void ChamaMenu()
        {
            string opcao;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("----------EMULADOR DE FILA----------");
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("---------[1] COLOCAR NA FILA--------");
                System.Console.WriteLine("---------[2] REMOVER DA FILA--------");
                System.Console.WriteLine("---------[3] VER QUEM ESTÁ NA VEZ---");
                System.Console.WriteLine("---------[4] CHECAR ITEM------------");
                System.Console.WriteLine("---------[5] LIMPAR FILA------------");
                System.Console.WriteLine("---------[6] SAIR-------------------");
                System.Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("------DIGITE A OPÇÃO ESCOLHIDA------");
                opcao = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        AcoesDoSistema.Enfileirar();
                        break;
                    case "2":
                        AcoesDoSistema.Desenfileirar();
                        break;
                    case "3":
                        AcoesDoSistema.VerPrimeiro();
                        break;
                    case "4":
                        AcoesDoSistema.VerificarSeExiste();
                        break;
                    case "5":
                        AcoesDoSistema.LimpaFila();
                        break;
                    default:
                        break;
                }

            } while (opcao != "6");
        }
    }
}