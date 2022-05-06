using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Infrastructure
{
    public class LibraryDatabaseContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}