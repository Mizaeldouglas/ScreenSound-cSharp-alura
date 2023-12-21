namespace ScreenSound.Podcasts;

public class Episodio
{
    public List<Convidado> Convidados { get; } = new();

    public Episodio(int duracao, string ordem, string resumo, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Resumo = resumo;
        Titulo = titulo;
    }

    public int Duracao { get; }
    public string Ordem { get; }
    public string Resumo { get; set; }
    public string Titulo { get; }


    public void AdicionarConvidado(Convidado convidados)
    {
        Convidados.Add(convidados);
    }
}