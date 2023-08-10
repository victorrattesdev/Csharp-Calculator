using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
            
            static void Menu()
            {
                Console.Clear();

                Console.WriteLine("Qual operação deseja realizar?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Raiz quadrada");
                Console.WriteLine("0- Sair do programa");

                Console.WriteLine("");
                Console.WriteLine("Seleciona uma opção:");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha) 
                {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Multiplicacao(); break;
                    case 4: Divisao(); break;
                    case 5: RaizQuadrada(); break;
                    case 0: System.Environment.Exit(0); break;
                    default: Menu(); break;
                }
            }
            
            
            static void RaizQuadrada()
            {
                Console.Clear();
                Console.WriteLine("Valor que deseja calcular a raiz: ");
                int v1 = int.Parse(Console.ReadLine ());
                int resultadoRaizQuadrada = v1*v1;
                Console.WriteLine($"o valor digitado é a raiz quadrada do número {resultadoRaizQuadrada}");
                Console.ReadKey();
                Menu();
            }
            static void Soma()
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor: ");
                int v1 = int.Parse(Console.ReadLine ());
                Console.WriteLine("Segundo valor: ");
                int v2 = int.Parse(Console.ReadLine());
                int resultado = v1 + v2;
                Console.WriteLine($"A soma dos valores é {resultado}");
                Console.ReadKey();
                Menu();
            }

            static void Subtracao()
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor:");
                int v1 = int.Parse(Console.ReadLine ());
                Console.WriteLine("Segundo valor: ");
                int v2 = int.Parse(Console.ReadLine());
                int resultadoSubtracao = v1-v2;
                Console.WriteLine($"A subtração dos valores é {resultadoSubtracao}");
                Console.ReadKey();
                Menu();
            }
            static void Divisao()
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor:");
                int v1 = int.Parse(Console.ReadLine ());
                Console.WriteLine("Segundo valor: ");
                int v2 = int.Parse(Console.ReadLine());
                int resultadoDivisao = v1/v2;
                Console.WriteLine($"A Divisão dos valores é {resultadoDivisao}");
                Console.ReadKey();
                Menu();
            }

            static void Multiplicacao()
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor:");
                int v1 = int.Parse(Console.ReadLine ());
                Console.WriteLine("Segundo valor: ");
                int v2 = int.Parse(Console.ReadLine());
                int resultadoMultiplicacao = v1*v2;
                Console.WriteLine($"A multiplicação dos valores é {resultadoMultiplicacao}");
                Console.ReadKey();
                Menu();
    }
  }
}
