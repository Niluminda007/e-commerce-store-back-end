using E_Commerce_Store.Models;

namespace E_Commerce_Store.DTO
{
    public class UserReponseDTO
    {
        public int Id { get; set; }
        public string? GoogleUID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int UserRoleId { get; set; }
        public string? PhotoURL { get; set; }


    }
}
