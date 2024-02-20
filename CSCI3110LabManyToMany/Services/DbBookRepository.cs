using CSCI3110LabManyToMany.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSCI3110LabManyToMany.Services;

public class DbBookRepository : IBookRepository
{
    private readonly ApplicationDbContext _db;

    public DbBookRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<ICollection<Book>> ReadAllAsync()
    {
        return await _db.Books.ToListAsync();
    }
}
