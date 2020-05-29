using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Generic_Study
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("숫자를 입력해 주세요!");
            
            string input = Console.ReadLine();
            
            Console.WriteLine(Pop<int?>(Convert.ToInt32(input)));
        }

        public static T Pop<T>(T value)
        {
            return value;
        }
    }

    public class NewStack<T>
    {
        T[] list = new T[3];

        public Task<T> GetValue<T>(T value, T value2)
        {
            return null;
        }
    }

    // struct : 값 형식만 가능
    public class GenericSample<Type> where Type : struct
    {

    }

    public class GenericSample<K, V> where K : IComparable where V : ICollection
    {
        public T GetValue<T>(T value)
        {   
            return value;
        }

        // class : 참조형식만 가능
        public void CheckNull<T>(T item) where T : class
        {
            if(item == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
