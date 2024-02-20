using CSCI3110LabManyToMany.Models.Entities;

namespace CSCI3110LabManyToMany.Services;

public class Initializer
{
    private readonly ApplicationDbContext _db;

    public Initializer(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task SeedDatabaseAsync()
    {
        _db.Database.EnsureCreated();

        // If there are no books then seed some.
        if (_db.Books.Any() == false)
        {
            var books = new List<Book>
            {
               new() { Title = "The Phoenix Project", PublicationYear = 2016 },
               new() { Title = "Java", PublicationYear = 1998 },
               new() { Title = "XML", PublicationYear = 1990},
               new() { Title = "Algorithms", PublicationYear = 2022 }
            };

            await _db.Books.AddRangeAsync(books);
            await _db.SaveChangesAsync();
        }

        // If there are no authors then seed some.
        if (_db.Authors.Any() == false)
        {
            var authors = new List<Author>
            {
               new() { FirstName = "John", LastName = "Bixby" },
               new() { FirstName = "Betty", LastName = "Flintstone" },
               new() { FirstName = "Fred", LastName = "Rubble"},
               new() { FirstName = "Marge", LastName = "Smith" }
            };

            await _db.Authors.AddRangeAsync(authors);
            await _db.SaveChangesAsync();
        }
    }
}

