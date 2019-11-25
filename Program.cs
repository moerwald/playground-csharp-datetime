using System;

namespace playground_csharp_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create date time string, where each segment is seperated by "_"
            Console.WriteLine(DateTime.UtcNow.ToString("o").Replace(":", "_").Replace(".", "_").Replace("-", "_"));
        }
    }
}
