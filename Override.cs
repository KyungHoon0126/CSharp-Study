using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Override
{
    class Override
    {
        class Mammal
        {
            virtual public void Move()
            {
                Console.WriteLine("이동한다.");
            }
        }

        class Lion : Mammal
        {
            override public void Move()
            {
                Console.WriteLine("네 발로 움직인다.");
            }
        }

        class Whale : Mammal
        {
            override public void Move()
            {
                Console.WriteLine("수영한다.");
            }
        }

        class Human : Mammal
        {
            override public void Move()
            {
                Console.WriteLine("두 발로 움직인다.");
            }
        }

        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Mammal mammal_one = lion; // 부모 타입으로 형변환
            mammal_one.Move();

            Human human = new Human();
            Mammal mammal_two = human;
            mammal_two.Move();
        }
    }
}
