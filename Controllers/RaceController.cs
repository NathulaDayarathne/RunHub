using Microsoft.AspNetCore.Mvc;
using RunHub.Data;
using RunHub.Models;
namespace RunHub.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()   //CCCCCCC
        {
            List<Race> races = _context.Races.ToList(); //MMMMMMM
            return View(races);  //VVVVVV
        }

    }
}
