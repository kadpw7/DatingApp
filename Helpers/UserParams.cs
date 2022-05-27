namespace DatingApp.Helpers
{
    public class UserParams : PaginationParams
    {
        public string? CurrentUsername { get; set; } = "lisa"; // The user that is logged in. We don't want to show it as a suggestion. Default is lisa. TODO: Make default be empty Username some how.
        public string? Gender { get; set; } = "female";
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 150;
        public string OrderBy { get; set; } = "lastActive";
    }
}