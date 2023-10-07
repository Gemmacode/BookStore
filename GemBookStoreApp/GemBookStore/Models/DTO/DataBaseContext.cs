using GemBookStore.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace GemBookStore.Models.DTO
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
            
        }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Books { get; set; }

       

    }
}
