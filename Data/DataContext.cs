using EstudoAsp.NetIdentity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstudoAsp.NetIdentity.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 1,
                Name = "Student",
                Email = "student@student.com",
                Curso = "Curso"
            });
    }
}
