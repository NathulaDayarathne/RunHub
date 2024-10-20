using Microsoft.AspNetCore.Mvc;

namespace RunHub.Controllers
{
	public class RaceController: Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	}
}
