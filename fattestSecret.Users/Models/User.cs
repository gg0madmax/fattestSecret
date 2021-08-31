namespace fattestSecret.Users.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string UserLogin { get; set; }
        public string Password { get; set; }
        public bool ConfirmPassword { get; set; }
    }
}