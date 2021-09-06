namespace fattestSecret.Users.Models
{
    public class CreationUserRequest
    {
        public string Email { get; set; }
        public string UserLogin { get; set; }
        public string Password { get; set; }
    }
}