        // Crie um dicionário para armazenar os produtos e suas quantidades em estoque
        Dictionary<string, int> estoque = new Dictionary<string, int>
        {
            { "maçãs", 20 },
            { "laranja", 10 },
            { "melão", 30 }
        };

        // Exiba o estoque de cada produto
        foreach (var produto in estoque)
        {
            Console.WriteLine($"Produto: {produto.Key}, Quantidade em estoque: {produto.Value}");
        }

        // Solicite o nome de um produto
        Console.Write("Digite o nome de um produto: ");
        string nomeProduto = Console.ReadLine();

        if (estoque.ContainsKey(nomeProduto))
        {
            int quantidade = estoque[nomeProduto];
            Console.WriteLine($"Quantidade de {nomeProduto} em estoque: {quantidade}");
        }
        else
        {
            Console.WriteLine($"O produto {nomeProduto} não está no estoque.");
}