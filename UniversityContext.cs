using Microsoft.EntityFrameworkCore;


public class UniversityContext : DbContext
{
    public DbSet<Student> Students {get;set;}
    public DbSet<Course> Courses {get;set;}
    public DbSet<Enrollment> Enrollments {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=university.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().ToTable("Student");
        modelBuilder.Entity<Course>().ToTable("Course");
        modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
    }
}



