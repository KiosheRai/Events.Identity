using System.ComponentModel.DataAnnotations;

namespace Events.Identity.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(12, ErrorMessage = "Password length less than 4", MinimumLength = 4)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfimPassword { get; set; }
        public string ReturnUrl { get; set; }
    }
}
