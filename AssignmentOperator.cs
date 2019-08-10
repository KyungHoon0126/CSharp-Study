using System;
using static System.Console;

namespace AssignmentOperator
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            int a;

            a = 100;
            WriteLine($"a = 100 : {a}");

            a += 90;
            WriteLine($"a += 90 : {a}");

            a -= 80;
            WriteLine($"a -= 80 : {a}");

            a *= 70;
            WriteLine($"a *= 70 : {a}");

            a /= 60;
            WriteLine($"a /= 60 : {a}");

            a %= 50;
            WriteLine($"a %= 50 : {a}");

            a &= 40;
            WriteLine($"a &= 40 : {a}");

            a |= 30;
            WriteLine($"a |= 30 : {a}");

            a ^= 20;
            WriteLine($"a ^= 20 : {a}");

            a <<= 10;
            WriteLine($"a <<= 10 : {a}");

            a >>= 1;
            WriteLine($"a >>= 1 : {a}");
        }
    }
}