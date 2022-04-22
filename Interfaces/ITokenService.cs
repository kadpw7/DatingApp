using DatingApp.Models;

namespace DatingApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
