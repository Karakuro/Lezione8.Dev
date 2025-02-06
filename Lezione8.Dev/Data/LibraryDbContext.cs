using Microsoft.EntityFrameworkCore;

namespace Lezione8.Dev.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext() : base() { }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) 
            : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
