using System;

namespace Object
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.1415_9265_3589_7932_3846_2643_3832_79m;
            object c = true;
            object d = "안녕하세요";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}