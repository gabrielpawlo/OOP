class Episodio
{
    private List<string> convidados = new List<string>();
    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"Episódio {Ordem}: {Titulo} - Duração: {Duracao} minutos - {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convindado)
    {
        convidados.Add(convindado);
    }
}