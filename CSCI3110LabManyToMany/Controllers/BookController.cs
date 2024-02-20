using CSCI3110LabManyToMany.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSCI3110LabManyToMany.Controllers;

public class BookController : Controller
{
    private readonly IBookRepository _bookRepo;

    public BookController(IBookRepository bookRepo)
    {
        _bookRepo = bookRepo;
    }

    public async Task<IActionResult> Index()
    {
        var allBooks = await _bookRepo.ReadAllAsync();
        return View(allBooks);
    }
}
