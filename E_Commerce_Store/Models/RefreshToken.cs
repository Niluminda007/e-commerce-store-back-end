namespace E_Commerce_Store.Models
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int  UserId { get; set; }
        public string Token { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expires { get; set; }
    }
}
