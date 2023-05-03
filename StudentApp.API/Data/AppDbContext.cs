using Microsoft.EntityFrameworkCore;
using CityApp.API.Data.Models;

namespace CityApp.API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
