using System;
using static System.Console;

namespace ShiftOperator
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("Testing <<...");

            int a = 1;

            WriteLine("a      : {0:D5} (0x{0:X8})", a);
            WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 1);
            WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 2);
            WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 5);


            WriteLine("\nTesting >>...");

            int b = 255;

            WriteLine("b       : {0:D5} (0x{0:X8})", b);
            WriteLine("b  >> 1 : {0:D5} (0x{0:X8})", b >> 1);
            WriteLine("b  >> 2 : {0:D5} (0x{0:X8})", b >> 2);
            WriteLine("b  >> 5 : {0:D5} (0x{0:X8})", b >> 5);


            WriteLine("\nTesting >> 2...");

            int c = -255;

            WriteLine("c      : {0:D5} (0x{0:X8})", c);
            WriteLine("c >> 1 : {0:D5} (0x{0:X8})", c >> 1);
            WriteLine("c >> 2 : {0:D5} (0x{0:X8})", c >> 2);
            WriteLine("c >> 5 : {0:D5} (0x{0:X8})", c >> 5);

        }
    }
}