namespace ScreenSound;

public class Banda
{
    private List<Album> _albuns = new List<Album>();
    public string Nome { get; set; }


    public Banda(string nome)
    {
        Nome = nome;
    }


    public void AdicionarAlbum(Album album)
    {
        _albuns.Add(album);
    }
    
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda: {Nome} \n");
        foreach (var album in _albuns)
        {
            Console.WriteLine($"Nome do álbum: {album.Nome}");
            foreach (var musica in _albuns)
            {
                Console.WriteLine($"Album: {musica.Nome}");
            }
        }
    }
}