using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_GenericClass
{
    // 형식 매개변수의 이름은 임의로 줄 수 있다.
    public class GenericSample<Type>
    {
        Type _item;

        public GenericSample(Type value)
        {
            _item = value;
        }
    }

    // 2개 이상 지정하는 것도 가능하다.
    public class TwoGeneric<K, V>
    {
        K _key;
        V _value;

        public void Set(K key, V value)
        {
            _key = key;
            _value = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
