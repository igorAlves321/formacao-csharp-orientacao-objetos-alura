using ScreenSound.modelos;

namespace ScreenSound.Modelos; 

class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> avaliacoes = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public List<Album> Albuns => albuns;
    public List<Avaliacao> Avaliacoes => avaliacoes;

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarAvaliacao(Avaliacao avaliacao)
    {
        avaliacoes.Add(avaliacao);
    }

    public int TotalGostei()
    {
        int totalGostei = 0;
        foreach (Avaliacao avaliacao in avaliacoes)
        {
            totalGostei += avaliacao.Gostei;
        }
        return totalGostei;
    }

    public int TotalNaoGostei()
    {
        int totalNaoGostei = 0;
        foreach (Avaliacao avaliacao in avaliacoes)
        {
            totalNaoGostei += avaliacao.NaoGostei;
        }
        return totalNaoGostei;
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}