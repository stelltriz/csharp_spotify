using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciciosCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banda queen = new Banda("Queen");
         
            Album albumDoQueen = new Album("A night at the opera");

            Genero genero1 = new Genero();
            genero1.Nome = "Rock";

            Musica musica1 = new Musica(queen, "Love of my life")
            {
                Duracao = 213,
                Genero = genero1,
            };

            Musica musica2 = new Musica(queen, "Teste")
            {
                Duracao = 400,
                Genero = genero1,
            };
            
            albumDoQueen.AdicionarMusica(musica1);
            albumDoQueen.AdicionarMusica(musica2);

            queen.AdicionarAlbum(albumDoQueen);

            queen.ExibirDiscografia();
            albumDoQueen.ExibirMusicasDoAlbum();
            musica1.ExibirFichaTecnica();

            Console.ReadLine();
        }

    }
}