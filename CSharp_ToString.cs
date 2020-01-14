using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString : ToString() 메소드를 호출하면 해당 인스턴스가 속한 클래스의 전체 이름을 반환.
            // BUT : ToString() 메서드는 자식 클래스에서 기능을 재정의할 수 있기 때문에 
            //       string을 비롯해서 C#에서 제공되는 기본 타입(short, int, ····)은 모두 해당 타입이 담고 있는 값을 반환.
            int n = 500;
            double d = 3.1415926535897932384626;

            string txt = "Hello : ";

            Console.WriteLine(txt + n.ToString());
            Console.WriteLine(txt + d.ToString());

            txt = d.ToString();

            Console.WriteLine(txt);
        }
    }
}
