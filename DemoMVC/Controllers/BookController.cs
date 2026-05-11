using DemoMVC.Data;
using DemoMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoMVC.ViewModels;
namespace DemoMVC.Controllers
{
    public class BookController(ApplicationDbContext context) : Controller
    {
        private readonly ApplicationDbContext _context = context;
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetBooks(int page = 1, int pageSize = 10)
        {
            var query = _context.Books
                .AsNoTracking()
                .OrderByDescending(x => x.CreatedDate);

            var totalItems = await query.CountAsync();

            var books = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var result = new PagedResult<Book>
            {
                Items = books,
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems
            };

            return PartialView("_BookTable", result);
        }
    }
}