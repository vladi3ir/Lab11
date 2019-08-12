using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {

        static void Main(string[] args)
        {

          
                GetMovieByCategory();
                 


        }


        public static void GetMovieByCategory()
        {
            bool exitApplication = true;



            while (exitApplication = true)
            {
                List<Movie> movies = new List<Movie>();

                movies.Add(new Movie("x-scifi movie1", "scifi"));
                movies.Add(new Movie("a-scifi movie2", "scifi"));
                movies.Add(new Movie("s-scifi movie3", "scifi"));
                movies.Add(new Movie("x-drama movie1", "drama"));
                movies.Add(new Movie("a-drama movie2", "drama"));
                movies.Add(new Movie("d-drama movie3", "drama"));
                movies.Add(new Movie("x-horror movie1", "horror"));
                movies.Add(new Movie("S-horror movie2", "horror"));
                movies.Add(new Movie("H-horror movie3", "horror"));
                movies.Add(new Movie("x-comedy movie1", "comedy"));
                movies.Add(new Movie("a-comedy movie2", "comedy"));
                movies.Add(new Movie("d-comedy movie3", "comedy"));
                movies.Add(new Movie("c-comedy movie4", "comedy"));



                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine($"There are {movies.Count} moves in this list  \n What category are you interested in: 1. scifi  2. drama  3. horror 4.comedy");

                List<string> _SortedList = new List<string>();


            again2:
                string _userInputCategory = Console.ReadLine();

                #region CONTAINS MATCHING LOGIC

                int SortedListSize = 0;

                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Category == _userInputCategory)
                    {
                        _SortedList.Add(movies[i].Titles);
                    }
                    else
                    {
                        SortedListSize += 1;
                    }
                }

                if (SortedListSize == movies.Count)
                {

                    Console.WriteLine("try again i didnt understand that, What category are you interested in: 1. scifi  2. drama  3. horror 4.comedy");
                    goto again2;
                }
                _SortedList.Sort();
                foreach (var item in _SortedList)
                {
                    Console.WriteLine(item);

                }





                Console.WriteLine("That was fun, do you want to exit [y]/[n]");
                string response = Console.ReadLine();

            tryagain:


                if (response == "y" | response == "Y")
                {
                    Console.WriteLine("Good-Bye");

                    Environment.Exit(0);

                }
                else if (response == "n" | response == "n")

                {
                    exitApplication = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("try again i didnt understand that, do you want to exit [y]/[n]");
                    response = Console.ReadLine();
                    goto tryagain;
                }

                #endregion



                #region First Try at it


                //    List<string> Titles = new List<string>();
                //    List<string> Category = new List<string>();
                //    List<string> SortedList = new List<string>();



                //    Titles.Add("x-scifi movie1");
                //    Titles.Add("a-scifi movie2");
                //    Titles.Add("s-sscifi movie3");
                //    Titles.Add("x-drama movie1");
                //    Titles.Add("a-drama movie2");
                //    Titles.Add("d-drama movie3");
                //    Titles.Add("x-horror movie1");
                //    Titles.Add("a-horror movie2");
                //    Titles.Add("h-horror movie3");
                //    Titles.Add("x-comedy movie1");
                //    Titles.Add("a-comedy movie2");
                //    Titles.Add("g-comedy movie3");
                //    Titles.Add("c-comedy movie4");


                //    Category.Add("scifi");
                //    Category.Add("scifi");
                //    Category.Add("scifi");
                //    Category.Add("drama");
                //    Category.Add("drama");
                //    Category.Add("drama");
                //    Category.Add("horror");
                //    Category.Add("horror");
                //    Category.Add("horror");
                //    Category.Add("comedy");
                //    Category.Add("comedy");
                //    Category.Add("comedy");
                //    Category.Add("comedy");



                //    Console.WriteLine("Welcome to the Movie List Application 1.0!");
                //    Console.WriteLine($"There are {movies.Count} moves in this list  \n What category are you interested in: 1. scifi  2. drama  3. horror 4.comedy");
                //again:
                //    string userInputCategory = Console.ReadLine();

                //    #region CONTAINS MATCHING LOGIC
                //    if (Category.Contains(userInputCategory))
                //    {
                //        for (int i = 0; i < Category.Count; i++)
                //        {
                //            if (Category[i] == userInputCategory)
                //            {
                //                SortedList.Add(Titles[i]);
                //            }
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("try again i didnt understand that, What category are you interested in: 1. scifi  2. drama  3. horror 4.comedy");
                //        goto again;

                //    }

                //    SortedList.Sort();


                //    foreach (var t in SortedList)
                //    {
                //        Console.WriteLine(t);
                //    }



                #endregion




            }


        }




    }
}
