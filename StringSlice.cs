using System;
using static System.Console;

namespace StringSlice
{
    public class MainApp
    {
        private static void Main(string[] args)
        {
            string greeting = "Good Morning.";

            WriteLine(greeting.Substring(0, 5)); // "Good"
            WriteLine(greeting.Substring(5)); // "morning"
            WriteLine();

            // string[] arr = greeting.Split (' ');

            string[] arr = greeting.Split(new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);
        }
    }
}