

using System.ComponentModel.DataAnnotations;

namespace reCAPTCHATest.Models.Account
{
    public class AccountViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string GoogleToken { get; set; }
    }
}