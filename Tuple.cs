using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple1 = (123, 789);
            Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}");


            var tuple2 = (Name: "김경훈", Age: 17);
            Console.WriteLine($"{tuple2.Name}, {tuple2.Age}");

            var (Name, Age) = tuple2; // 튜플 분해
            Console.WriteLine($"{Name}, {Age}");


            var tuple3 = (Name: "김경훈", Age: 17);
            var (name, _) = tuple3; // 튜플을 분해할 때 특정 필드를 무시하고 싶으면 _를 이용한다. age 필드는 무시한다.
            Console.WriteLine($"{name}");



            // 명명되지 않은 튜플과 명명된 튜플끼리는 필드의 수와 형식이 같으면 할당이 가능하다.

            var unnamed = ("슈퍼맨", 9999); // 명명되지 않은 튜플
            var named = (Name: "박상현", Age: 17); // 명명된 튜플

            named = unnamed;
            Console.WriteLine($"{named.Name}, {named.Age}"); // 출력 결과 : 슈퍼맨, 9999

            named = ("원더우먼", 10000);

            unnamed = named;
            Console.WriteLine($"{unnamed.Item1}, {unnamed.Item2}"); // 출력 결과 : 원더우먼, 10000
        }
    }
}
