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
        $"A musica {Nome} pertence a {Artista.NomeBanda}";
 

    public void FichaMusica()
    {
        Console.WriteLine($"Nome da musica: {Nome}");
        Console.WriteLine($"Artista: {Artista.NomeBanda}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}\n");
    }
}
