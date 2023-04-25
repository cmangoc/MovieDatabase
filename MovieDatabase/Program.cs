namespace MovieDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adds to the list of movies
            bool goOn = true;
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("The Super Mario Bros Movie", "animated"));
            movieList.Add(new Movie("Puss in Boots: The Last Wish", "animated"));
            movieList.Add(new Movie("Shrek", "animated"));
            movieList.Add(new Movie("Spider-Man: Into the Spider-Verse", "animated"));
            movieList.Add(new Movie("The Whale", "drama"));
            movieList.Add(new Movie("The Unbearable Weight of Massive Talent", "drama"));
            movieList.Add(new Movie("The Exorcist", "horror"));
            movieList.Add(new Movie("As Above, So Below", "horror"));
            movieList.Add(new Movie("Nope", "horror"));
            movieList.Add(new Movie("Interstellar", "scifi"));
            movieList.Add(new Movie("Star Wars", "scifi"));
            movieList.Add(new Movie("2001: A space Odyssey", "scifi"));

            //Greets the user
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();

            while (goOn)
            {
                //outputList is used to display the list of movies for every run
                List<string> outputList = new List<string>();
                Console.WriteLine($"There are {movieList.Count} movies on this list.");
                Console.WriteLine("What category are you interested in? ");
                string input = "";
                bool invalid = true;
                //requires the user to select from the displayed categories and loops if they choose something invalid
                while (input != "animated" && input != "drama" && input != "horror" && input != "scifi")
                {
                    Console.WriteLine("Please select: [1]animated, [2]drama, [3]horror, or [4]scifi");
                    input = Console.ReadLine().Trim().ToLower();
                    if (input == "animated" || input == "drama" || input == "horror" || input == "scifi")
                    {
                        invalid = false;
                        continue;
                    }
                    else if (input == "1" || input == "2" || input == "3" || input == "4")
                    {
                        if (input == "1")
                        {
                            input = "animated";
                        }
                        else if (input == "2")
                        {
                            input = "drama";
                        }
                        else if (input == "3")
                        {
                            input = "horror";
                        }
                        else if (input == "4")
                        {
                            input = "scifi";
                        }
                        invalid = false; 
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid category, try again.");
                        invalid = true;
                    }
                }
                //takes the input and adds to the outputList all of the movies for their selected cateogry
                List<Movie> output = movieList.Where(movie => movie.Category == input).ToList();
                foreach (Movie m in output)
                {
                    outputList.Add(m.Title);
                }
                //makes the list in alphabetical order
                List<string> ordered = outputList.OrderBy(x => x).ToList();
                //displays the movies requested from the list
                foreach (string s in ordered)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                goOn = Continue();
                Console.WriteLine();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Continue? (y/n): ");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }
    }
}