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
        Console.WriteLine($"Digite a placa do veículo para estacionar:");
        string placaDoVeiculo = Console.ReadLine();

        //Verificação do input do usuário, para que o programa não aceite uma entrada vazia.
        if (string.IsNullOrWhiteSpace(placaDoVeiculo))
        {   
            Console.WriteLine("A placa do veículo não pode ser vazia. Tente novamente inserindo caracteres válidos.");
            return; 
        }

        //verificação da existência ou não da placa na lista veiculos 
        if (!veiculos.Contains(placaDoVeiculo)) 
        {  
            veiculos.Add(placaDoVeiculo.ToUpper());
            Console.WriteLine($"Veículo com a placa {placaDoVeiculo} foi estacionado com sucesso!");
        }
        else
        {
            Console.WriteLine($"Veículo com a placa {placaDoVeiculo} já está no estacionamento.");
        }

        }

        //Metodo para remover o veículo do estacionamento e informar o valor a ser pago.
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);                  
                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O valor para estacionar é: R$ {precoInicial} e o valor por hora passada é: R$ {precoPorHora}.");
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                //Laço para exibir os veículos estacionados e utilização da propriedade "Count" para informar a quantidade de carros.
                Console.WriteLine($"Os veículos estacionados são: {veiculos.Count()}");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
