namespace DatingApp.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime bdate)
        {
            var today = DateTime.Today;
            
            var age = today.Year - bdate.Year;

            if (bdate.Date.AddYears(age) < today) // If the user didn't yet have a birthday this year
                age--;

            return age;

        }
    }
}
