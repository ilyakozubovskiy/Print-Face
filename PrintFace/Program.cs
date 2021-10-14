using System;

namespace PrintFace
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, world!");
        }

        public static void SayHelloUser(string userName)
        {
            Console.WriteLine("Hello, {0}!", userName);
        }
        
        public static void PrintFace()
        {
            string s = $" +\"\"\"\"\"+{Environment.NewLine}" +
                               $"(| o o |){Environment.NewLine}" +
                               $" |  ^  |{Environment.NewLine}" +
                               $" | '-' |{Environment.NewLine}" +
                               $" +-----+";
            Console.WriteLine(s);
        }
    }
}
