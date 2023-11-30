namespace ScreenSound.Modelos;

class Album
{
    private List<Musica> musicas = new List<Musica>();
    private List<Album> AlbumContador = new();

    public Album(string nome)
    {
        Nome = nome;
        ContadorDeAlbuns++;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public static int ContadorDeAlbuns = 0;

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }

}