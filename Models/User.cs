using System.ComponentModel.DataAnnotations;


namespace ServerSideValidation.Models
{
    public class User
    {
        [Required(ErrorMessage = "User ID is required.")]
        [Range(1, 1000, ErrorMessage = "User ID must be a positive integer.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(40, ErrorMessage = "Username must be between 5 and 40 characters long.", MinimumLength = 5)]
        public string Username { get; set;

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

       
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string PhoneNumber { get; set; }


        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }


        [Url(ErrorMessage = "Invalid URL format.")]
        public string WebSite { get; set; }


        [CreditCard(ErrorMessage = "Invalid credit card number.")]
        public string CreditCard { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, ErrorMessage = "Password must be at least 6 characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}