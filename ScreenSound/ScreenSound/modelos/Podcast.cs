﻿namespace ScreenSound.modelos
{
    public class Podcast
    {
        private List<Episodio> episodios = new();
        public string Nome { get; }
        public string Host { get; }
        public int TotalEpisodios => episodios.Count;

        public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }


        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast >|{Nome}|< apresentado por [{Host}]\n");
            foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
            }
            Console.WriteLine($"\n\nTotal de episódios: {TotalEpisodios}.");
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }
    }
}
