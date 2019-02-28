using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreamsDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var names = GetNames();

            await foreach(var name in names)
            {
                Console.WriteLine($"{name}");
            }
        }

        private static async IAsyncEnumerable<string> GetNames()
        {
            var names = new[] { "John Doe", "Jan Kowalski", "Piotr Nowak", "Lech Roch Pawlak", "Tiger Bonzo" };

            foreach(var name in names)
            {
                await Task.Delay(1000);
                yield return name;
            }
        }
    }
}
