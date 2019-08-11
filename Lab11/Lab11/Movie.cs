using System;
using System.Collections.Generic;

namespace Lab11
{
    public class Movie
    {
        public string Titles { get; set; }
        public string Category { get; set; }


        public Movie(string title, string category) // default constructor
        {
            Titles = title;
            Category = category;


        }

        public static void GetMovieByCategory()
        {
            bool exitApplication = true;


            while (exitApplication = true)
            {

                List<string> Titles = new List<string>();
                List<string> Category = new List<string>();
                List<string> SortedList = new List<string>();



                Titles.Add("x-scifi movie1");
                Titles.Add("a-scifi movie2");
                Titles.Add("s-sscifi movie3");
                Titles.Add("x-drama movie1");
                Titles.Add("a-drama movie2");
                Titles.Add("d-drama movie3");
                Titles.Add("x-horror movie1");
                Titles.Add("a-horror movie2");
                Titles.Add("h-horror movie3");
                Titles.Add("x-comedy movie1");
                Titles.Add("a-comedy movie2");
                Titles.Add("g-comedy movie3");
                Titles.Add("c-comedy movie4");


                Category.Add("scifi");
                Category.Add("scifi");
                Category.Add("scifi");
                Category.Add("drama");
                Category.Add("drama");
                Category.Add("drama");
                Category.Add("horror");
                Category.Add("horror");
                Category.Add("horror");
                Category.Add("comedy");
                Category.Add("comedy");
                Category.Add("comedy");
                Category.Add("comedy");



                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine($"There are {Titles.Count} moves in this list  \n What category are you interested in: 1. scifi  2. drama  3. horror 4.comedy");
            again:
                string userInputCategory = Console.ReadLine();

                #region CONTAINS MATCHING LOGIC
                if (Category.Contains(userInputCategory))
                {
                    for (int i = 0; i < Category.Count; i++)
                    {
                        if (Category[i] == userInputCategory)
                        {
                            SortedList.Add(Titles[i]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("try again i didnt understand that, What category are you interested in: 1. scifi  2. drama  3. horror 4.comedy");
                    goto again;

                }

                SortedList.Sort();


                foreach (var t in SortedList)
                {
                    Console.WriteLine(t);
                }



                #endregion

                #region IGNORE


                //List<string> MovieList = new List<string>();
                //List<string> Category = new List<string>();

                //MovieList.Add("Movie1");
                //MovieList.Add("Movie2");
                //MovieList.Add("Movie3");
                //MovieList.Add("Movie4");

                //Category.Add("Comedy");
                //Category.Add("Drama");
                //Category.Add("Scifi");
                //Category.Add("Horror");



                //Console.WriteLine($"Movie           Category");
                //Console.WriteLine($"-----           --------");


                //for (int i = 0; i < 4; i++)
                //{
                //    Console.WriteLine($"{MovieList[i]}           {Category[i]}");

                //}


                //Console.WriteLine("Add a movie");
                //MovieList.Add(Console.ReadLine());

                //Console.WriteLine("Add a category for the movie");
                //Category.Add(Console.ReadLine());

                //for (int i = 0; i < 5; i++)
                //{
                //    Console.WriteLine($"{MovieList[i]}           {Category[i]}");

                //}

                //Console.WriteLine("-------------------");
                //for (int i = 0; i < 5; i++)
                //{
                //    if (Category[i] == "Comedy" | Category[i] == "comedy")
                //    {
                //        Console.WriteLine(MovieList[i]);

                //    }
                //}
                #endregion

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



            }


        }




    }
}
