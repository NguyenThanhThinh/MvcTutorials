using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEF
{
    class Program
    {
        static void Main(string[] args)
        {
           using (var context = new BookContext())
            {
                context.ComicBooks.Add(new Models.ComicBook()
                {
                    SeriesTitle="Tinh yeu va noi nho",
                    IssueNumber=1,
                    PublishedOn=DateTime.Today

                });
                context.SaveChanges();
                var comicBook = context.ComicBooks.ToList();
                foreach (var item in comicBook)
                {
                    Console.WriteLine(item.SeriesTitle);
                }
                Console.ReadLine();
            }
        }
    }
}
