using System;

namespace playground_csharp_datetime
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Create date time string, where each segment is seperated by "_"
            Console.WriteLine(DateTime.UtcNow.ToString("o").Replace(":", "_").Replace(".", "_").Replace("-", "_"));

            // Convert to seconds since Unix epoch
            Console.WriteLine(ConvertToUnixTimestamp(DateTime.UtcNow));
        }

        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }
    }
}
