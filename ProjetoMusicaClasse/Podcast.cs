class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    private List<Episodio> ListaEpisodios { get; } = new List<Episodio>();
    public int TotalEpisodios => ListaEpisodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        ListaEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine(Nome, Host);
        foreach (var episodio in ListaEpisodios.OrderBy(e => e.Numero))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nTotal de episódios: {TotalEpisodios}");
    }
}