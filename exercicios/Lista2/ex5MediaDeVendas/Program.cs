Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

foreach (var carro in vendasCarros)
{
    Console.WriteLine($"Carro: {carro.Key}, Vendas: {string.Join(", ", carro.Value)}");
}

// Calculando a soma das vendas e a média
double somaDasVendas = vendasCarros.Values.SelectMany(v => v).Sum();
int numeroDeVendas = vendasCarros.Values.SelectMany(v => v).Count();
double media = somaDasVendas / numeroDeVendas;
Console.WriteLine($"A média das vendas de carros é: {media}");
Console.ReadKey();
