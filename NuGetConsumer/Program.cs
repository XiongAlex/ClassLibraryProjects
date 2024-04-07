using StringLibrary;
using System;
namespace NuGetConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting NuGetConsumer application...");

            // Example usage of StringLibrary.StartsWithUpper method from your NuGet package
            string testString = "Hello from NuGet package";
            bool startsWithUpper = StringLibrary.StartsWithUpper(testString);

            Console.WriteLine($"Does '{testString}' start with an uppercase letter? {startsWithUpper}");

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}