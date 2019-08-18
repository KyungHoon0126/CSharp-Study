using System;

namespace InfiniteFor
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            int i = 0;

            for(; ; )
            {
                Console.WriteLine(i++);
            }
        }
    }
}