namespace fattestSecret.Users.Models
{
    public class UpdateUserRequest : CreationUserRequest
    {
        public long Id { get; set; }
        public bool ConfirmPassword { get; set; }
    }
}