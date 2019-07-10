using System;

namespace IntegralConversion
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128;  // sbyte의 최대값 127보다 1 큰수
            Console.WriteLine(x);

            sbyte y = (sbyte)x; // 오버플로우 발생
            Console.WriteLine(y);
        }
    }
}