using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {

            string continueFlag;
            do
            {



                var movies = new List<Movie>()
            {

                new Movie(){Title = "Luca", Category= "Animated" },
                new Movie(){Title = "Steam Boat Willy", Category= "Animated" },
                new Movie(){Title = "Dune", Category= "Sci-Fi" },
                new Movie(){Title = "Back to the Future", Category= "Sci-fi" },
                new Movie(){Title = "Texas Chainsaw Massacer", Category= "Horror" },
                new Movie(){Title = "Get Out", Category= "Horror" },
                new Movie(){Title = "The Big Sick", Category= "Drama" },
                new Movie(){Title = "Avengers Endgame", Category= "Drama" },
                new Movie(){Title = "Blade Runner", Category= "Sci-Fi" },
                new Movie(){Title = "Captain America: The First Avenger", Category= "Drama" },

            };

            
                 listofMovies(movies);


                Console.WriteLine("Do you want to continue (y/n)");
                continueFlag = Console.ReadLine();

            } while (continueFlag == "y");

        }


        static string UserInput(string message)
        {

            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {

                    Console.WriteLine("Not a Valid Category");

                }


            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public static void listofMovies(List<Movie> movies)

        {
            string input = UserInput("What is the Category you are interested in \r\n 1.Drama \r\n 2.Animated \r\n 3.Sci-Fi \r\n 4.Horror");
            var results = movies.Where(movie => movie.Category == input);


            foreach (var movie in results)
            {
                Console.WriteLine($"{(movie.Title)}");

            }


        }



    }
}
