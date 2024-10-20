using Microsoft.AspNetCore.Mvc;
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

	}
}
