using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Utility
{
    // IComparable 인터페이스를 상속받은 타입만 T에 대입.
    // where 예약어를 사용해 제한 가능.
    public static T Max<T>(T item1, T item2) where T : IComparable
    {
        if (item1.CompareTo(item2) >= 0)
        {
            return item1;
        }

        return item2;
    }
}


namespace GenericIComparable
{
    class GenericIComparable
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Utility.Max(10, 50));
            Console.WriteLine(Utility.Max("Abc", "def"));
            Console.WriteLine(Utility.Max(true, false));
        }
    }
}
