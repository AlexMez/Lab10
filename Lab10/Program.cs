using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            string animated = "animated";
            string horror = "horror";
            string drama = "drama";
            string sciFi = "sci-Fi";

            List<Movie> MyMovieList = new List<Movie>();
          
            MyMovieList.Add(new Movie("NightMare on Elm Street", horror));
            MyMovieList.Add(new Movie("I know what you did last summer", horror));
            MyMovieList.Add(new Movie("The devil's rejects", horror));
            MyMovieList.Add(new Movie("Forest Gump", drama));
            MyMovieList.Add(new Movie("Ghost in the Shell", drama));
            MyMovieList.Add(new Movie("The Matrix", sciFi));
            MyMovieList.Add(new Movie("Blade Runner", sciFi));
            MyMovieList.Add(new Movie("2001 Space Odyssey", sciFi));
            MyMovieList.Add(new Movie("Wall-E", animated));
            MyMovieList.Add(new Movie("Frozen", animated));

            Console.WriteLine("What category are you interested in?: ");
            Console.WriteLine("1) Horror");
            Console.WriteLine("2) Sci-Fi");
            Console.WriteLine("3) Drama");
            Console.WriteLine("4) Animated");

            int Userinput = Validate.RangeValidator(1, 4);

            string CataGory = Choose(Userinput);

            foreach (var item in MyMovieList)
            {
                if (item.Category1 == CataGory)
                {
                    Console.WriteLine(item.Title1);
                }
            }

        }
           
                                  

        public static string Choose(int input)
        {
            string Cate;
            string animated = "animated";
            string horror = "horror";
            string drama = "drama";
            string sciFi = "sci-Fi";
            switch (input)
            {

                case 1:
                    Cate = horror;
                    return Cate;
                    
                case 2:
                    Cate = sciFi;
                    return Cate;
                    
                case 3:
                    Cate = drama;
                    return Cate;
                   
                case 4:
                    Cate = animated;
                    return Cate;
                default:
                    Console.WriteLine("error");
                    return "horror";  
            }

            



            
        }
        
        
    }
}
