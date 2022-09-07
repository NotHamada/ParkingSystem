namespace DesafioFundamentos.Models;

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
        placa = placa.ToUpper();

        if (placa.Length == 8)
        {
            veiculos.Add(placa);
            Console.WriteLine("Veículo estacionado com sucesso!");
        }
        else
            Console.WriteLine("Placa inválida!");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine();

        if (veiculos.Any(x => x == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            int horas = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = Convert.ToDecimal(precoInicial + precoPorHora * horas);

            veiculos.Remove(placa.ToUpper());

            Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
    }

    public void ListarVeiculos()
    {
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
            Console.WriteLine("Não há veículos estacionados.");
    }
}

