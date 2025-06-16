using System.ComponentModel.DataAnnotations;


namespace ServerSideValidation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }
        public string WebSite { get; set; }
        public string CreditCard { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}