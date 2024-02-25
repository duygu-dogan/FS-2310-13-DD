using AjaxIntro.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AjaxIntro
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        { 
            
        }
        public DbSet<Student> Students { get; set; } 
    }
}
