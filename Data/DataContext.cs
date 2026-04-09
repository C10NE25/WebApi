using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> products {get;set;}
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}