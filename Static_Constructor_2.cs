using CSharp_Static_Constructor_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Static_Constructor_2
{
    class Person
    {
        public string _name;

        public Person(string name)
        {
            _name = name;
            Console.WriteLine("ctor 실행"); // ctor : static constructor. 정적 생성자
        }

        static Person() // 정적 생성자에는 매개변수가 들어갈 수 없다.
        {
            Console.WriteLine("ctor 실행");
        }
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정적 생성자는 클래스의 어떤 멤버든 최초로 접근하는 시점에 단 한 번만 실행된다.
            // 즉 정적 멤버를 처음 호출할 경우 또는 인스턴스 생성자를 통해 객체가 만들어지는 시점이 되면 어떤 코드보다 우선적 실행.
            Person person1 = new Person(""); // Person 클래스의 인스턴스 생성, 따라서 Person 생성자에서 출력 한 번, 정적 생성자에서 출력 한 번 진행.
            Console.WriteLine("---------"); 
            Person person2 = new Person(""); // Person 클래스의 인스턴스 생성으로 출력 한 번.
        }
    }
}
