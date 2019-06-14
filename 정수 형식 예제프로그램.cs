using System;

namespace IntegralTypes
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = -10; // sbyte = sigend byte 정수, 1byte, -128 ~ 127
            byte b = 40; // byte = 부호없는 정수, 1byte, 0 ~ 255

            Console.WriteLine("a = {0}, b = {1}", a, b);

            short c = -30000; // short = 정수, 2byte, -32,768 ~ 32,767
            ushort d = 60000; // ushort = unsiged short 부호없는 정수, 2byte, 0 ~ 65,535

            Console.WriteLine("c = {0}, d = {1}", c, d);

            int e = -10000000; // int = 정수, 4byte, -2,147,483,648 ~ 2,147,483,647
            uint f = 300000000; // unit = unsiged int 부호없는 정수, 4byte, 0 ~ 4,294,967,295

            Console.WriteLine("e = {0}, f = {1}", e, f);

            long g = -500000000000; // long = 정수, 8byte, -922,337,203,685,477,508 ~ 922,337,203,685,477,507
            ulong h = 2000000000000000000; // unsiged long 부호없는 정수, 8byte, 0 ~ 18,446,744,073,709,551,615

            Console.WriteLine("g = {0}, h = {1}", g, h);

            // char = 유니코드 문자, 2byte

        }
    }
}