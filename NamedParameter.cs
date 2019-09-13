using System;

namespace NamedParameter
{
    public class MainApp
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-9876", name: "박지성");
            PrintProfile(name: "박세리", phone: "010-222-2222");
            PrintProfile(name: "김경훈", phone: "010-567-5678");
        }
    }
}