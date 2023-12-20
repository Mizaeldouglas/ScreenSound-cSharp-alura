using System.Collections;

namespace ScreenSound;

public class Album
{
    private List<Musica> _musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => _musicas.Sum(m => m.Duracao);
    

    public void AdicionarMusica(Musica musica)
    {
        _musicas.Add(musica);
    }

    public void ExibirMusicaDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome} \n");
        foreach (var musica in _musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
            Console.WriteLine($"Artista: {musica.Artista}");
            Console.WriteLine($"Duração: {musica.Duracao}");
        }
    }
}