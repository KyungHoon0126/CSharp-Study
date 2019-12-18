using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mathematics
{
    delegate int Calcdelegate(int x, int y);

    static int Add(int x, int y) { return x + y; }
    static int Subtract(int x, int y) { return x - y; }
    static int Multiply(int x, int y) { return x * y; }
    static int Divide(int x, int y) { return x / y; }

    Calcdelegate[] methods;

    public Mathematics()
    {
        // static 메서드를 가리키는 델리게이트 배열 초기화
        methods = new Calcdelegate[] { Mathematics.Add, Mathematics.Subtract, Mathematics.Multiply, Mathematics.Divide };
    }

    public void Calculate(char opCode, int operand1, int operand2)
    {
        switch(opCode)
        {
            case '+':
                Console.WriteLine("+: " + methods[0](operand1, operand2));
                break;
            case '-':
                Console.WriteLine("-: " + methods[1](operand1, operand2));
                break;
            case '*':
                Console.WriteLine("*: " + methods[3](operand1, operand2));
                break;
            case '/':
                Console.WriteLine("/: " + methods[4](operand1, operand2));
                break;
        }
    }
}

namespace CSharp_UsingDelegate
{
    public class UsingDelegate
    {
        // 3개의 매개변수를 받고 void를 반환하는 델리게이트 정의
        // 매개변수의 타입이 중요할 뿐 매개변수의 이름은 임의로 정할 수 있다.
        delegate void WorkDelegate(char arg1, int arg2, int arg3);
        
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            WorkDelegate work = math.Calculate;

            math.Calculate('+', 10, 5);
            work('+', 10, 5);

            math.Calculate('-', 10, 5);
            work('-', 10, 5);

            math.Calculate('*', 10, 5);
            work('*', 10, 5);

            math.Calculate('/', 10, 5);
            work('/', 10, 5);
        }
    }
}