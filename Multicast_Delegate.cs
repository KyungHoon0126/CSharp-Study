using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MulticastDelegate
{
    class Multicast_Delegate
    {
        delegate void CalcDelegate(int x, int y);

        static void Add(int x, int y) { Console.WriteLine(x + y); }
        static void Subtract(int x, int y) { Console.WriteLine(x - y); }
        static void Multiply(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }

        static void Main(string[] args)
        {
            CalcDelegate plusCalc = Add;
            //CalcDelegate calc = new CalcDelegate(Add);

            // += 연산자를 이용해 메서드를 델리게이트 인스턴스에 추가해주는 역할을 한다.
            plusCalc += Subtract;
            plusCalc += Multiply;
            plusCalc += Divide;

            plusCalc(10, 5);


            //CalcDelegate minusCalc = Add;
            CalcDelegate minusCalc = new CalcDelegate(Add);

            minusCalc += Subtract;
            minusCalc += Multiply;
            minusCalc += Divide;

            minusCalc(10, 5); // Add, Subtract, Multiply, Divide 메서드 모두 호출

            // -= 연산자를 이용하면 MulticastDelegate의 메서드 보관 목록에서 해당 메서드를 제거하는 역할을 한다.
            minusCalc -= Multiply; // 목록에서 Multiply 메서드를 제거
            minusCalc(10, 5); // Add, Subtract, Divide 메서드만 호출
        }
    }
}
