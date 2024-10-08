using System;
using ITI_MVC_Asssignment.Data.Config;
using ITI_MVC_Asssignment.Models;
using Microsoft.EntityFrameworkCore;
namespace ITI_MVC_Asssignment.Data;

public class AppDbContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<CourseResult> CourseResults { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseConfig).Assembly);
    }


}
