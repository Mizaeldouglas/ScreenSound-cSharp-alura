namespace ScreenSound.Podcasts;

public class Podcast
{
    private List<Episodio> _episodios = new List<Episodio>();
    private List<Convidado> _convidados = new List<Convidado>();
    private int _contadorEpisodios = 0;
    public int TotalEpisodios => _contadorEpisodios;
    

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; set; }
    public string Nome { get; set; }
    
    
    
    public void AdicionarEpisodio(Episodio episodio)
    {
        _episodios.Add(episodio);
        _contadorEpisodios++;
    }
    public void ExibirEpisodios()
    {
        Console.WriteLine($"Tem {TotalEpisodios} episódios no podcast {Nome} \n");
        foreach (var episodio in _episodios)
        {
            Console.WriteLine($"Episódio: {episodio.Titulo}");
            Console.WriteLine($"Resumo: {episodio.Resumo}");
            Console.WriteLine($"Duração: {episodio.Duracao}");
            Console.WriteLine($"Ordem: {episodio.Ordem}");
            Console.WriteLine("Convidados:");
            foreach (var convidado in episodio.Convidados)
            {
                Console.WriteLine($" - {convidado.Nome}");
            }

            Console.WriteLine();
            
        }
    }
}