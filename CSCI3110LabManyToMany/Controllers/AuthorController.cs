using CSCI3110LabManyToMany.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSCI3110LabManyToMany.Controllers;

public class AuthorController : Controller
{
    private readonly IAuthorRepository _authorRepo;

    public AuthorController(IAuthorRepository authorRepo)
    {
        _authorRepo = authorRepo;
    }

    public async Task<IActionResult> Index()
    {
        var allAuthors = await _authorRepo.ReadAllAsync();
        return View(allAuthors);
    }
}
