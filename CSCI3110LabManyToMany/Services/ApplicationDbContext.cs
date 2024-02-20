using CSCI3110LabManyToMany.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSCI3110LabManyToMany.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Book> Books => Set<Book>();
    public DbSet<Author> Authors => Set<Author>();
}

