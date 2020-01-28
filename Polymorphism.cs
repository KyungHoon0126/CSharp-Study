using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Polymorphism
{
    class Mammal
    {
        public void Move()
        {
            Console.WriteLine("이동한다.");
        }
    }

    class Lion : Mammal
    {
        //public void Move()
        //{
        //    Console.WriteLine("네 발로 움직인다.");
        //}

        new public void Move() // 순수하게 독립적인 하나의 메서드로 이름을 정의하고 싶은 경우 new 키워드를 이용.
        {
            Console.WriteLine("네 발로 움직인다.");
        }
    }

    class Whale : Mammal
    { 
        public void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }

    class Human : Mammal
    {
        public void Move()
        {
            Console.WriteLine("두 발로 움직인다.");
        }
    }

    class Polymorphism
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Move();

            Lion lion = new Lion();
            lion.Move();

            Whale whale = new Whale();
            whale.Move();

            Human human = new Human();
            human.Move();
        }
    }
}
