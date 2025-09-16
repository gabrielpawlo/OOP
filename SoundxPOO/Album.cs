class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        NomeAlbum = nome;
    }

    public string NomeAlbum { get; }
    public int Duracao => musicas.Sum(m => m.Duracao);


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicas()
    {
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}\n");
        }
        Console.WriteLine($"Duração do album: {Duracao} segundos\n");
    }
}