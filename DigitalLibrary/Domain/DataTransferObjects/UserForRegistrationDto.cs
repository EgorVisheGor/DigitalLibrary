using System.ComponentModel.DataAnnotations;

namespace Domain.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; init; }
        
        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; init; }
        
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; init; }
        
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; init; }
        
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; init; }
    }
}
