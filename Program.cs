using SistemaEstacionamento;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

        Console.WriteLine("Digite o preço inicial:");
        decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o preço por hora:");
        decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Entrada de veículo");
            Console.WriteLine("2 - Retirada de veículo");
            Console.WriteLine("3 - Lista de veículos");
            Console.WriteLine("5 - Encerrar");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;

                case "2":
                    estacionamento.RemoverVeiculo();
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                
                case "4":
                    exibirMenu = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}
