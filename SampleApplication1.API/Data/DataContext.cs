using Microsoft.EntityFrameworkCore;
using SampleApplication1.API.Model;

namespace SampleApplication1.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}