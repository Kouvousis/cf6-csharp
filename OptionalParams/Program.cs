namespace OptionalParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime1 = GetDateTime();
            Console.WriteLine($"{dateTime1:D}");

            DateTime dateTime2 = GetDateTime();
            Console.WriteLine($"{dateTime2:F}");
        }

        public static DateTime GetDateTime(int year=2024, int month=11, int day=18, int min=0, int sec=0, int milli=0) 
        {
            return new DateTime(year, month, day, min, sec, milli, DateTimeKind.Utc);
        }
    }
}
