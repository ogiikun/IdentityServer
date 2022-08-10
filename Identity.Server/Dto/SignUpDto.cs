using System.ComponentModel.DataAnnotations;

namespace Identity.Server.Dto
{
    public class SignUpDto
    {
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
