namespace E_Commerce_Store.Models
{
    public class UserRegisterModel
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string? Password { get; set; }
        public string Email { get; set; }
        public string?  Address { get; set; }
        public string? PhotoUrl { get; set; }
        public string? GoogleUId { get; set; }

    }
}
