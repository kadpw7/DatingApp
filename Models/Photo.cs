using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Models
{
    [Table("Photos")] // This tells EF to call this Photos in the db
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string? PublicId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}