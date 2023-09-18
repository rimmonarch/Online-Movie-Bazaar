using System.ComponentModel.DataAnnotations;

namespace MovieStoreMvc.Models.DTO
{
	public class RegistrationModel
	{
		[Required]
		public string Name { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		public string UserName { get; set; }
		[Required]
		[RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z](?.*?[0-9])(?=.*[#@^+!*$()])^")]
		public string Password { get; set; }
		[Required]
		[Compare("Password")]
		public string PasswordConfirmation { get; set; }
		public string Role { get; set; }
	}
}
