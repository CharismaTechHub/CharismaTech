using System.ComponentModel.DataAnnotations;

namespace CT.Website.Models
{
	public class User
	{
        [Required(ErrorMessage = "Please add your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please add your last name")]
        public string LastName { get; set; }

		public string Company { get; set; }

        [Required(ErrorMessage = "Please add your email address")]
        [EmailAddress(ErrorMessage = "Please add a valid email address")]
        public string Email { get; set; }

		public string Message { get; set; }
	}
}