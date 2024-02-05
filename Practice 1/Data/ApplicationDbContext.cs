using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Practice_1.Models;

namespace Practice_1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet <Student> Students { get; set; }

        public DbSet <Grade> Grades { get; set; }

        public DbSet <Subject> Subjects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
