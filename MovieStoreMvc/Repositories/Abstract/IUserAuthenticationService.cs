using MovieStoreMvc.Models.DTO;

namespace MovieStoreMvc.Repositories.Abstract
{
	public interface IUserAuthenticationService
	{
		Task<Status> LoginAsync(LoginModel model);

		Task<Status> RegisterAsync(RegistrationModel model);
        //Task<Status> ChangePassWordAsync(ChangePasswordModel model ,string username)
        Task LogoutAsync();
    }
}