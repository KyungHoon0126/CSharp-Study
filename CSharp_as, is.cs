using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_as__is
{
    class Program
    {
        static void Main(string[] args)
        {
            // as : 형변환이 가능하면 지정된 타입의 인스턴스 값 반환, 가능하지 않으면 null을 반환.
            // 주의 할 점 : 참조형 변수에 대해서만 적용할 수 있다. 즉 참조형 타입으로의 체크만 가능.
            int n = 5;
            if((n as string) != null)
            {
                Console.WriteLine("변수 n은 string 타입"); // 컴파일 오류 발생
            }

            string txt = "text";
            if((txt as int) != null)
            {
                Console.WriteLine("변수 txt는 int 타입"); // 컴파일 오류 발생
            }


            // is : 형변환의 가능성 여부를 불린형의 결괏값(true/false)로 반환.
            // is 연산자는 값 형식에 사용 가능.
            int num = 5;
            if(num is string)
            {
                Console.WriteLine("변수 n은 string 타입");
            }

            string text = "text";
            if(text is int)
            {
                Console.WriteLine("변수 txt는 int 타입");
            }
        }
    }
}
