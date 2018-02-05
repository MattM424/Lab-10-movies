using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_Movies
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                #region Fill

                MovieObject pitch = new MovieObject("Pitch Black", "Action", 1);
                MovieObject thor = new MovieObject("thor", "Action", 1);
                MovieObject Star = new MovieObject("Star wars", "Sci-fi", 5);
                MovieObject Good = new MovieObject("Goodfellas", "Biography", 3);
                MovieObject Inter = new MovieObject("Interstellar", "Sci-fi", 5);
                MovieObject Alien = new MovieObject("Alien", "Sci-fi", 5);
                MovieObject Ing = new MovieObject("Inglourious Basterds", "War", 6);
                MovieObject Pirate = new MovieObject("Pirates of the Caribbean", "Adventure", 2);
                MovieObject Nemo = new MovieObject("Finding Nemo", "Drama", 4);
                MovieObject Park = new MovieObject("Jurassic Park", "Adventure", 2);

                #endregion
                MovieObject[] Movies = { pitch, thor, Star, Good, Inter, Alien, Ing, Pirate, Nemo, Park };

                //Console.WriteLine(Movies[4].genere);


                Console.WriteLine("Welcome to the Movie Database\n\nPlease pick from one of the catagorys.\n1. Action\n2. Adventure\n3. Biography\n4. Drama\n5. Sci-fi\n6. War");
                int UserInput = int.Parse(Console.ReadLine());


                for (int i = 0; i < Movies.Length; i++)
                {
                    if (UserInput == Movies[i].CatagoryNum)
                    {
                        Console.WriteLine(Movies[i].Movietitle);
                    }

                }
                Console.WriteLine("Would you like to continue? (y/n)");
                if (Console.ReadLine().ToLower() != "y")
                    break;

            }
        }

        //private static void MovieList(MovieObject[] Movies)
        //{
    


        //}
    }
}
