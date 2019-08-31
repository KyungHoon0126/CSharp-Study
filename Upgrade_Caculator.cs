using System;

namespace Upgrade_Caculator
{
    public class Upgrade_Caculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }

    public class MainApp
    {
        public static void Main()
        {
            int result = Upgrade_Caculator.Plus(2, 4);
            Console.WriteLine(result);

            result = Upgrade_Caculator.Minus(6, 2);
            Console.WriteLine(result);

            result = Upgrade_Caculator.Multiply(4, 8);
            Console.WriteLine(result);

            result = Upgrade_Caculator.Divide(16, 4);
            Console.WriteLine(result);
        }
    }
}