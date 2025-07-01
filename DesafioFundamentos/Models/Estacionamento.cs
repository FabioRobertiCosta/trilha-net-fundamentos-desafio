using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{

    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Veículo já cadastrado no estacionamento!");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine($"Digite a placa do veículo para fechar a fatura:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"Digite a quantidade de horas estacionadas:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo de placas {placa} está faturado e o preço total é: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine($"Desculpe! Placa inválida! Digite a placa corretamente!");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos Estacionados");
                foreach (string v in veiculos)
                {
                    Console.WriteLine($"- {v}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }
    }
}
