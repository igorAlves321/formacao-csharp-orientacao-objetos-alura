using Ex02Estoque;

class Program
{
    static void Main(string[] args)
    {
        Produto produto1 = new Produto
        {
            Nome = "Produto 1a",
            Marca = "Verde",
            Preco = 100.0,
            Estoque = 50
        };

        // Criando outro produto
        Produto produto2 = new Produto
        {
            Nome = "Produto 2b",
            Marca = "Marca azul",
            Preco = 200.0,
            Estoque = 30
        };

        // Criando o estoque de produtos
        EstoqueDeProdutos estoque = new EstoqueDeProdutos();

        // Adicionando os produtos ao estoque
        estoque.AdicionarProduto(produto1);
        estoque.AdicionarProduto(produto2);

        // Exibindo os produtos no estoque
        estoque.ExibirProdutos();
    }
}
