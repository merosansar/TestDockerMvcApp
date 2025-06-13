using System.Data;
using Microsoft.EntityFrameworkCore;
using TestDockerMvcApp.Models;

namespace TestDockerMvcApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions):base(dbContextOptions) 
        {



        }
        public DbSet<User> Users { get; set; }

    }
}
