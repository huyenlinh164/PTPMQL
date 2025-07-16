
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Persons { get; set;}  
        public DbSet<DaiLy> DaiLy { get; set; } 
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi{ get; set;}  

    }
}