using System;

namespace Problems
{
    public class Program
    {
        string Prefix(string input)
        {
            int len = input.Length;
            string[] arr = input.Split();
            int numWords = arr.Length;
            string output = Convert.ToString(len) + "," + Convert.ToString(numWords) + ":" + input;

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
