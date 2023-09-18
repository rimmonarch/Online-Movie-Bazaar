using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MovieStoreMvc.Controllers
{
	[Authorize (Roles = "Admin")]
	public class AdminController : Controller
	{
		public IActionResult Display()
		{
			return View();
		}
	}
}
