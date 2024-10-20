using Microsoft.EntityFrameworkCore;
using NewMvcProject;
using NewMvcProject.Models;

namespace NewMvcProject.Data{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<Person> Persons { get; set; }
    }
}