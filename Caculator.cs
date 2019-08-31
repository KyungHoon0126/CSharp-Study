using System;

namespace Caculaotr
{
    public class Caculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    public class MainApp
    {
        public static void Main()
        {
            int result = Caculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Caculator.Minus(5, 2);
            Console.WriteLine(result);
        }
    }
}