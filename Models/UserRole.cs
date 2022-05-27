using Microsoft.AspNetCore.Identity;

namespace DatingApp.Models
{
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; set; }
        public AppRole Role { get; set; }

    }
}
