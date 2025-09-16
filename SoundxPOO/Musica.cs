class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; } // duração em segundos
    public Genero Genero { get; set; }
    public bool Disponivel {get; set; }
    public string DescricaoResumida => 
        $"Nome da musica: {Nome}\nArtista: {Artista.NomeBanda}\nGenero: {Genero.Nome}";
 

    public void FichaMusica()
    {
        Console.WriteLine($"Nome da musica: {Nome}");
        Console.WriteLine($"Artista: {Artista.NomeBanda}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Gênero: {Genero.Nome}");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}\n");
    }
}
