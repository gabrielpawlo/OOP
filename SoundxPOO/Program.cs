Banda beatle = new Banda("Beatles");
Banda sarcofago = new Banda("Sarcofago");

Musica musica1 = new Musica(beatle, "Let it be");
musica1.Duracao = 240;
musica1.Disponivel = true;

Musica musica2 = new Musica(beatle, "Hey Jude");
musica2.Duracao = 300;
musica2.Disponivel = true;

Musica musica3 = new Musica(sarcofago, "Nightmare");
musica3.Duracao = 180;
musica3.Disponivel = false;

Musica musica4 = new Musica(sarcofago, "Crucifixion");
musica4.Duracao = 200;
musica4.Disponivel = true;

Playlist playlist1 = new Playlist("Playlist Beatles", 1);
playlist1.AdicionarMusica(musica1);
playlist1.AdicionarMusica(musica2);

Playlist playlistMetal = new Playlist("Playlist Metal", 2);
playlistMetal.AdicionarMusica(musica3);
playlistMetal.AdicionarMusica(musica4);

List<Playlist> playlists = new List<Playlist> { playlist1, playlistMetal };

foreach (var playlist in playlists.OrderBy(p => p.Ordem))
{
    Console.WriteLine($"Playlist {playlist.Ordem}:");
    playlist.ExibirMusicas();
    Console.WriteLine();
}
