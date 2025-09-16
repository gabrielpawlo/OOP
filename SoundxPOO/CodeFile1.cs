using System.Security.Cryptography;

class Banda
{
    private List<Album> Albuns = new List<Album>();

    public Banda(string nome)
    {
        NomeBanda = nome;
    }

    public string NomeBanda { get; }

    public void AdicionarAlbum(Album album)
    {
        Albuns.Add(album);
    }

    public void ExibirAlbuns()
    {
        Console.WriteLine($"Discografia da banda {NomeBanda}");

        foreach (var album in Albuns)
        {
            Console.WriteLine($"Album: {album.NomeAlbum} {(album.Duracao)}\n");
        }
    }
}