using ScreenSound.modelos;

Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidado("Maria");
ep1.AdicionarConvidado("Marcelo");

Episodio ep2 = new(2, "Tecnicas de aprendizado", 67);
ep2.AdicionarConvidado("Fernando");
ep2.AdicionarConvidado("Marcos");
ep2.AdicionarConvidado("Flavia");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
