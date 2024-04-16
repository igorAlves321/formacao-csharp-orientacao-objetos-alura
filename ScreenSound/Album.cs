class Album
{
    public string Nome { get; set; }
    public List<Musica> Musicas { get; set; }

    public Album()
    {
        Musicas = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }
}
