using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunHub.Data;
using RunHub.Interfaces;
using RunHub.Models;
namespace RunHub.Controllers
{
	public class ClubController: Controller
	{
        
		private readonly IClubRepository clubRepository;

		public ClubController(IClubRepository clubRepository)
        { 
			this.clubRepository = clubRepository;
		}

        public async Task<IActionResult> Index()   //CCCCCCC
		{
            IEnumerable<Club> clubs = await clubRepository.GetAll(); //MMMMMMM
            return View(clubs);  //VVVVVV
		}

        public async Task<IActionResult> Detail(int id)   //CCCCCCC
        {
            Club club = await clubRepository.GetByIdAsync(id); //MMMMMMM

			return View(club);  //VVVVVV
        }

    }
}
