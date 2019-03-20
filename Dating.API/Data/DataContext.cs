using Dating.API.models;
using Microsoft.EntityFrameworkCore;

namespace Dating.API.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) : base (options) {} 

         public DbSet<Value> Values { get; set;}
    }
}