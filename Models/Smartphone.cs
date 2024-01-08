using System.Diagnostics;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo {get; set;}
        protected string Imei {get;set;}
        protected int Memoria {get;set;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            this.Modelo = modelo;
            this.Imei = imei;
            this.Memoria = memoria;
        }

        public void Config()
        {
            Console.Clear();
            Console.WriteLine("Acessando as confiurações.");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("Acessando as confiurações..");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("Acessando as confiurações...");
            Thread.Sleep(800);

            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Emei: {Imei}");
            Console.WriteLine($"Memoria: {Memoria}");
            Console.WriteLine($"Número: {Numero}");
        }

        public void Ligar()
        {
            Console.Clear();
            Console.WriteLine("Selecione um contato para ligar:");
            Console.WriteLine("\n1. Mãe\n2. Pai\n3. Irmão");
            int selecao = Int32.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                Console.Clear();
                Console.WriteLine("Ligando para 'Mãe'...");
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.WriteLine("Chamada perdida...");
                break;

                case 2:
                Console.Clear();
                Console.WriteLine("Ligando para 'Pai'...");
                Thread.Sleep(1000);
                Console.WriteLine("O número que você ligou está fora de area ou desligado.");
                break;
                
                case 3:
                Console.Clear();
                Console.WriteLine("Ligando para 'Irmão'...");
                Thread.Sleep(1000);
                Console.WriteLine("O número que você ligou está fora de area ou não existe.");
                break;

                default:
                Ligar();
                break;
            }
        }

        public void ReceberLigacao()
        {   
            Console.Clear(); 
            Console.WriteLine("Recebendo ligação...\nPossível fraude.\nAtender? (S/N)");
            string escolha = Console.ReadLine();

            if (escolha == "s" || escolha == "S")
            {
                Console.Clear();
                Console.WriteLine("\nAlo? Aqui é do Banco do Brasil...");
            }
            else if (escolha == "n" || escolha == "N")
            {
                Console.Clear();
                Console.WriteLine("\nChamada recusada!");
            }
            else
            {
                Console.WriteLine("\nComando desconhecido.\n");
                ReceberLigacao();
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}