using Microsoft.EntityFrameworkCore;

namespace Lezione8.Dev.Data
{
    public class LibraryDbContext : DbContext
    {
        private readonly Logger _logger;
        public LibraryDbContext(Logger logger) : base() {
            _logger = logger;
        }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options, Logger logger) 
            : base(options)
        {
            _logger = logger;
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
