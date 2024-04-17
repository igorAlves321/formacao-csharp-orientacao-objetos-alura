using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Estoque
{
    public class EstoqueDeProdutos
    {
        private List<Produto> Produtos { get; set; } = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque");
        }

        public void ExibirProdutos()
        {
            if (Produtos.Count == 0)
            {
                Console.WriteLine("Estoque vazio. Nenhum produto disponível");
            }else
            {
                Console.WriteLine("Lista de produtos no estoque:");
                foreach (var produto in Produtos)
                {
                    Console.WriteLine(produto.Descricao);
                }
            }
        }
    }
}
