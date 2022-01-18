using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENSIDHOM_Oussama_TP3_ST2TRD
{
    class EX1
    {
        public void exercie1()
        {
            var movies = new MovieCollection().Movies;

            var query1 = movies
                .OrderBy(c => c.ReleaseDate)
                .First()
                .Title;
            Console.WriteLine(query1);

            var query2 = movies
                .Count();
            Console.WriteLine(query2);

            var query3 =
                from mov in movies
                where (mov.Title.Contains("e"))
                select mov.Title;
            Console.WriteLine(query3.Count());

            //var q3 = movies.Count(x => x.Title.Contains('e')); 

            var query4 =
                from mov in movies
                where (mov.Title.Contains("f"))
                select mov.Title;
            int t = 0;
            foreach (var title in query4)
            {
                t = t + title.Count(f => f == 'f');
            }
            Console.WriteLine(t);

            var query5 = movies
                .OrderBy(c => c.Budget)
                .Last()
                .Title;
            Console.WriteLine(query5);

            var query6 = movies
                .OrderBy(c => c.BoxOffice)
                .First()
                .Title;
            Console.WriteLine(query6);

            var query7 = movies
                .OrderByDescending(c => c.Title)
                .Take(11);
            foreach (var item in query7)
            {
                Console.WriteLine(item.Title);
            }

            var query8 = movies
               .Count(c => c.ReleaseDate.Year < 1980);
            Console.WriteLine(query8);

            var query9 = movies
                .Where(c => c.Title.StartsWith("A") || c.Title.StartsWith("E") || c.Title.StartsWith("I") || c.Title.StartsWith("O") || c.Title.StartsWith("U") || c.Title.StartsWith("Y"))
                .Average(x => x.RunningTime);
            Console.WriteLine(query9);

            var query10 = movies
                .Where(c => (c.Title.Contains("h") || c.Title.Contains("w")) & (c.Title.Contains("i") == false & c.Title.Contains("t") == false));
            foreach (var item in query10)
            {
                Console.WriteLine(item.Title);
            }

            var query11 = movies
                .Average(x => x.Budget / x.BoxOffice);
            Console.WriteLine(query11);
        }
    }
}
