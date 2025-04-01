class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }
    public Genero Genero { get; set; }

    public string Descricao => $"A música {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome} \nArtista: {Artista.Nome} \nDuração: {Duracao} \nGenêro: {Genero.Nome}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano premium");
        }
    }

    public void ExibirNomeEArtista() 
    {
        Console.WriteLine($"Nome: {Nome} | Artista: {Artista}");
    }
}

