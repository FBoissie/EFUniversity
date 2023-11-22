//donner les noms et autres paramètres de la base de données => les tables en gros

using Microsoft.EntityFrameworkCore;


public class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public string DbPath { get; private set; }

    public UniversityContext()
    {
        // Path to SQLite database file
        DbPath = "Data\\EFUniversity.db";
    }


    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        //options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}


//migration : photo du modele à l'instant t => 3 classes (students, courses, enrollments)
//application de migration => 3 tables 


