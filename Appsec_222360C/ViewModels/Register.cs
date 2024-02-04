using System.ComponentModel.DataAnnotations;

namespace Appsec_222360C.ViewModels
{
    public class Register
    {
        [Required]
        [DataType(DataType.Text)]
        public string firstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string nric { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password and confirmation password does not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        public string resume { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string whoAmI { get; set; }
    }
}
