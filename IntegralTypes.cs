using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralTyeps
{
    public class Mainapp
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a = {a}, b = {b}");
            // Console.WriteLine("a = {0}, b = {1}", a, b);
            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c = {c}, d = {d}");
            // Console.WriteLine("c = {0}, d = {1}", c, d);

            int e = -1000_000; // 0이 7개
            uint f = 3_0000_0000; // 0이 8개

            Console.WriteLine($"e = {e}, f = {f}");
            // Console.WriteLine("e = {0}, f = {1}", e, f);

            long g = -5000_0000_0000; // 0이 11개
            ulong h = 200_0000_0000_0000_0000; // 0이 18개

            Console.WriteLine($"g = {g}, h = {h}");
            // Console.WriteLine("g = {0}, h = {1}", g, h);
        }
    }
}