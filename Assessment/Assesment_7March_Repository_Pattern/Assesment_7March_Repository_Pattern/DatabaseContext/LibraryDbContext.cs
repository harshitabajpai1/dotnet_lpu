using Microsoft.EntityFrameworkCore;
using Assesment_7March_Repository_Pattern.Models;       

namespace Assesment_7March_Repository_Pattern.DatabaseContext
{
    public class LibraryDbContext: DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
           : base(options)
        {
        }


        public DbSet<Book> Books { get; set; }
    }
}
