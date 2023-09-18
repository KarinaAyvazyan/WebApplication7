using Microsoft.EntityFrameworkCore;
using WebApplication7.Data.Entities;

namespace WebApplication7.Data
{
    public class UniversityDataContext:DbContext    
    {
        public UniversityDataContext(DbContextOptions<UniversityDataContext> options) : base(options)
        { }
        public DbSet<Faculty> Faculties { get; set; }       
        public DbSet<Student> Students { get; set; }        
    }
}
