namespace E_Commerce_Store.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? GoogleUID { get; set; }
        public  string UserName { get; set; }
        public string? Password { get; set; }
        public string FullName { get; set; }
        public string  Email { get; set; }
        public string?  Address { get; set; }
        
        public ICollection<Order>? Orders { get; set; }
        public UserRole UserRole { get; set; }
        public int UserRoleId { get; set; }
        public string? PhotoURL { get; set; }
        public ICollection<Review>? Reviews { get; set; }

        public ICollection<RefreshToken>? RefreshTokens { get; set; }


    }
}
