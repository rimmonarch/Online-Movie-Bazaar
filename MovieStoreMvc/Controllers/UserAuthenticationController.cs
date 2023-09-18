using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieStoreMvc.Models.DTO;
using MovieStoreMvc.Repositories.Abstract;

namespace MovieStoreMvc.Controllers
{
	public class UserAuthentication : Controller
	{
		//private IUserAuthenticationService authService;
        //public UserAuthenticationController(IUserAuthenticationService authService)
       // {
        //    this.authService = authService;
        //}
       // public IActionResult Register()
		//{

		//	return View();
		//}

        private readonly IUserAuthenticationService authService;
		public UserAuthentication(IUserAuthenticationService authService)
        {
            this.authService = authService;
        }
        
		public IActionResult Registration()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Registration(RegistrationModel model)
		{
			if (!ModelState.IsValid)
				return View(model);
			model.Role = "user";
			var result = await authService.RegisterAsync(model);
			TempData["msg"] = result.Message;
			return RedirectToAction(nameof(Registration));
		}
        public async Task<IActionResult> Login()
		{
			return View();
		}
		[HttpPost]
		public  async Task<IActionResult> Login(LoginModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

		var result = await authService.LoginAsync(model);
		if(result.StatusCode ==1) 
		{
			return RedirectToAction("Display", "DashBoard");
		}
		else
		{
			TempData["msg"] = result.Message;
			return RedirectToAction(nameof(Login));
		}
		}

		[Authorize]
        public async Task<IActionResult> Logout()
        {
            await authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }


       /* public async Task <IActionResult>Reg()
		{
			var model = new RegistrationModel()
			{
				UserName = "admin",
				Name = "Debangi Nag",
				Email = "debangi@gmail.com",
				Password = "Deb@1234"
			};
			model.Role = "user";
			var result = await authService.RegisterAsync(model);
			return Ok(result);	
		}*/

    }
}
