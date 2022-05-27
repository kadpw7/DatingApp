using Microsoft.AspNetCore.Identity;

namespace DatingApp.Models
{
    public class User : IdentityUser<int>
    {
        public DateTime DateOfBirth { get; set; }
        public string? Nickname { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string? Gender { get; set; }
        public string? Introduction { get; set; }
        public string? LookingFor { get; set; }
        public string? Interests { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public ICollection<Photo>? Photos { get; set; }

        public ICollection<UserLike>? LikedByUsers { get; set; }
        public ICollection<UserLike>? LikedUsers { get; set; }

        public ICollection<Message>? MessagesSent { get; set; }

        public ICollection<Message>? MessagesRecieved { get; set; }

        public ICollection<UserRole>? UserRoles { get; set; }

        /*public int GetAge() // Automapper looks for methods calles GetX and maps them to X. So in our case this will be mapped to the Age property in MemberDTO.
        {
            return DateOfBirth.CalculateAge();
        }*/
    }
}