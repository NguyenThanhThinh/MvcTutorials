using BookEF.Models;
using System.Data.Entity;

namespace BookEF
{
    public class BookContext:DbContext
    {
        public BookContext() : base("BookContext")
        {

        }
        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}
