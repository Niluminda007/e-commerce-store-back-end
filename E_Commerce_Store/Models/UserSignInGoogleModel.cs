namespace E_Commerce_Store.Models
{
    public class UserSignInGoogleModel
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? PhotoURL { get; set; }
        public string Token { get; set; }
    }
}
