

using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DTOs
{
    public class LoginDTO
    {
        [EmailAddress] 
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }=string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
