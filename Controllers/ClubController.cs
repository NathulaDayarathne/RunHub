using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunHub.Data;
using RunHub.Models;
namespace RunHub.Controllers
{
	public class ClubController: Controller
	{
        private readonly ApplicationDbContext _context;

        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()   //CCCCCCC
		{
            List<Club> clubs = _context.Clubs.ToList(); //MMMMMMM
            return View(clubs);  //VVVVVV
		}

        public IActionResult Detail(int id)   //CCCCCCC
        {
            Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id); //MMMMMMM
            return View(club);  //VVVVVV
        }

    }
}
