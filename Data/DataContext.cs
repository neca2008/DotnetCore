using Microsoft.EntityFrameworkCore;
using ProAgil.WebApi.Model;

namespace ProAgil.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    }
}