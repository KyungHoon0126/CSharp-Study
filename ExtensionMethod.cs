using System;
using MyExtension;

namespace MyExtension
{
    // 확장 메소드 : 기존 클래스의 기능을 확장시키는 기법, 메소드를 선언하되 static 한정자로 수식 그리고 메소드의 첫 번째 매개변수는 반드시 this 키워드와 사용.
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
            {
                result = result * myInt;
            }

            return result;
        }
    }
}

namespace ExtensionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
        }
    }
}