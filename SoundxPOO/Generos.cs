class Genero
{
    private List<Musica> musicas = new List<Musica>();

    public Genero(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public void DescricaoGenero()
    {
        Console.WriteLine($"Gênero: {Nome}");
        Console.WriteLine($"Número de músicas: {musicas.Count}\n");
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

}