using System;

namespace DesafioPOO.Models
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo! Escolha um celular:");
            Console.WriteLine("1. iPhone");
            Console.WriteLine("2. Nokia");

            int escolhaCelular = LerInteiro("Escolha o número do celular: ");

            Smartphone celular;

            switch (escolhaCelular)
            {
                case 1:
                    celular = new Iphone("123456789", "iPhone X", "123456789012345", 64);
                    break;
                case 2:
                    celular = new Nokia("987654321", "Nokia 3310", "987654321098765", 16);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Saindo do programa.");
                    return;
            }

            ExibirMenuCelular(celular);
        }

        static void ExibirMenuCelular(Smartphone celular)
        {
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("Menu do Celular:");
                Console.WriteLine("1. Configurações");
                Console.WriteLine("2. Fazer Ligação");
                Console.WriteLine("3. Receber Ligação");
                Console.WriteLine("4. Instalar Aplicativo");
                Console.WriteLine("5. Mudar número telefonico");
                Console.WriteLine("6. Sair.");

                int escolha = LerInteiro("Escolha uma opção: ");

                switch (escolha)
                {
                    case 1:
                        celular.Config();
                        break;
                    case 2:
                        celular.Ligar();
                        break;
                    case 3:
                        celular.ReceberLigacao();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Digite o nome do aplicativo a ser instalado: ");
                        string nomeApp = Console.ReadLine();
                        celular.InstalarAplicativo(nomeApp);
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Digite o novo número do celular: ");
                        string novoNumero = Console.ReadLine();
                        celular.Numero = novoNumero;
                        Console.WriteLine("Número do celular alterado com sucesso!");
                        break;
                    case 6:
                        sair = true;
                        Console.WriteLine("Saindo do programa. Até logo!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                    Console.WriteLine("\nPressione uma tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
            }
        }

        static int LerInteiro(string prompt)
        {
            int valor;
            do
            {
                Console.Write(prompt);
            } while (!int.TryParse(Console.ReadLine(), out valor));
            return valor;
        }
    }
}
