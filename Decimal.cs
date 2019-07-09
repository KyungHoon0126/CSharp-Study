using System;

namespace Decimal
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;   // f를 붙이면 float 형식으로 간주
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;   // 아무것도 없으면 double
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m; // m을 붙이면 decimal

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}