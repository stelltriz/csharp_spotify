class Episodio
{
    public Episodio(int numero, string titulo, int duracao)
    {
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Numero { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    private List<String> Convidados { get; } = new();
    public string Resumo => $"{Numero} | {Titulo} | {Duracao} | {string.Join(",", Convidados)}";
    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }


}