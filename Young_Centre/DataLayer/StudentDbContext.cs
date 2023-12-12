using Microsoft.EntityFrameworkCore;
using Young_Centre.Model;

namespace Young_Centre.DataLayer
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> db) : base(db)
        { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employe> Employes { get; set; }
    }
}

