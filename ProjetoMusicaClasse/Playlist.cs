class Playlist 
{
    public Playlist(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    List<Musica> ListaDeMusicas { get; set; } = new List<Musica>();

    public void ExibirPlaylist()
    {
        Console.WriteLine($"Nome da playlist: {Nome}");
        if (ListaDeMusicas.Count > 0) {
            
            foreach (Musica musica in ListaDeMusicas)
            {
                Console.WriteLine(musica);
            }
        }
        else
        {
            Console.WriteLine("Sua playlist está vazia");
        }
    }
}
