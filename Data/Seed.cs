using DatingApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace DatingApp.Data
{
    public class Seed
    {
        public static async Task SeedUsers(DataContext context)
        {
            if (await context.Users.AnyAsync())
                return;

            var userData = await File.ReadAllTextAsync("Data/UserSeedData.json");

            var users = JsonSerializer.Deserialize<List<User>>(userData);

            foreach(var user in users)
            {
                using var hmac = new HMACSHA512();

                user.Username = user.Username.ToLower();

                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("12345")); // Same password for all the users, since this is just a demonstration app.

                user.PasswordSalt = hmac.Key;

                context.Users.Add(user);
            }

            await context.SaveChangesAsync();
        }
    }
}