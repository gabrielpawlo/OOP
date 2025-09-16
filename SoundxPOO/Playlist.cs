class Playlist
{
    private List<Musica> musicas = new List<Musica>();

    public Playlist(string nome, int ordem)
    {
        Nome = nome;
        Ordem = ordem;
    }
    public string Nome { get; }
    public int Ordem { get; }
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicas()
    {
        Console.WriteLine($"Músicas na {Nome}:");
        foreach(var musica in musicas)
        {
            Console.WriteLine(musica.DescricaoResumida);
        }
    }
}