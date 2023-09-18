using Microsoft.AspNetCore.Mvc;

namespace MovieStoreMvc.Controllers
{
	public class DashBoardController : Controller
	{
		public IActionResult Display ()
		{
			return View();
		}
	}
}
