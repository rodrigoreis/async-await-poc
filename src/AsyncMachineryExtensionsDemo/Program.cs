using System;
using System.Threading.Tasks;

namespace AsyncMachineryExtensionsDemo
{
    internal static class Program
    {
        private static async Task AsyncTask()
        {
            Console.WriteLine("Executing user code");
            await Task.Delay(125);
        }

        private static async Task Main(string[] args)
        {
            var task = AsyncTask();
            await task;
        }
    }
}
