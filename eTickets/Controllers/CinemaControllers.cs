using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemaControllers : Controller
    {
        private readonly AppDbContext _context;

        public CinemaControllers(AppDbContext _context)
        {
            _context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Cinemas.ToListAsync();
            return View();

        }
    }
}
