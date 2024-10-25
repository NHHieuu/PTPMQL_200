using Microsoft.EntityFrameworkCore;
using NewMvcProject;
using NewMvcProject.Models;

namespace NewMvcProject.Data{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Persons { get; set; }
    }
}