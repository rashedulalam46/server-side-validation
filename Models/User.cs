using System.ComponentModel.DataAnnotations;


namespace ServerSideValidation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string WebSite { get; set; }
        public string CreditCard { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}