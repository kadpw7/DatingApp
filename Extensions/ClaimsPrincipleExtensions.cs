using System.Security.Claims;

namespace DatingApp.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            string username = user.FindFirst(ClaimTypes.Name)?.Value;
            return username;
        }

        public static int GetUserId(this ClaimsPrincipal user)
        {
            int id = int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return id;
        }
    }
}