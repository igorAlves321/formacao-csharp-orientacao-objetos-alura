Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica("Love of my life", "Queen");
Musica musica2 = new Musica("Bohemian Rhapsody", "Queen");

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.ExibirMusicasDoAlbum();
Console.ReadKey();