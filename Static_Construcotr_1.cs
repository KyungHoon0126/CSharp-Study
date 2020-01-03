using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Static_Constructor
{
    class Person
    {
        static public Person President; // = new Person("대통령") 초기화 코드를
                                        // 정적 생성자로 이전해서 컴파일
        public string _name;

        private Person(string name)
        {
            _name = name;
        }

        // 정적 생성자는 클래스의 어떤 멤버든 최초로 접근하는 시점에 단 한 번만 실행된다.
        static Person() // 정적 생성자
        {
            President = new Person("대통령"); // 정적 필드 초기화
        }

        static void Main(string[] args)
        {
            Console.WriteLine(President._name);
        }
    }
}
