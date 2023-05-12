using Microsoft.EntityFrameworkCore;
using University.Data.Models;

namespace University.Data
{
    public class DBContent : DbContext
    {
        public DBContent(DbContextOptions<DBContent> options)
        : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
