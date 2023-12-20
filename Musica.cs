namespace ScreenSound;

public class Musica
{
    private string _nome;
    private string _artista;
    private int _duracao;
    private bool _disponivel;

    private string DescricaoResumida =>
        $"A música {Nome} pertence ao artista {Artista} e tem duração de {Duracao} segundos.";


    public Musica(string nome, string artista, int duracao, bool disponivel)
    {
        _nome = nome;
        _artista = artista;
        _duracao = duracao;
        _disponivel = disponivel;
    }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine("Nome da música: " + Nome);
        Console.WriteLine("Artista: " + Artista);
        Console.WriteLine("Duração: " + Duracao);
        Console.WriteLine("Descrição: " + DescricaoResumida);
        Console.WriteLine(Disponivel ? "Disponível no Plano" : "Não disponível no Plano, assine agora!");
    }

    public string Nome
    {
        get => _nome;
        set => _nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Artista
    {
        get => _artista;
        set => _artista = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Duracao
    {
        get => _duracao;
        set => _duracao = value;
    }

    public bool Disponivel
    {
        get => _disponivel;
        set => _disponivel = value;
    }
}