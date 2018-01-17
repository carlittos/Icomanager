using Icomanger.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Icomanger.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users {get; set;}


    }
}