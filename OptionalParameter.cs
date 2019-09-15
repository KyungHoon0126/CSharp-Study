using System;

namespace Optional_Parameter
{
    public class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
        
        public static void Main(string[] args)
        {
            PrintProfile("태연");
            PrintProfile("윤아", "010-123-4567");
            PrintProfile("유리");
            PrintProfile("서현", phone:"010-789-7890");
        }
    }
}