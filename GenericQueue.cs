using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_GenericQueue
{
    // T : 형식 매개변수
    class GenericQueue<T>
    {
        public T[] array; // array : 형식 매개변수의 배열
        private int count = 0;

        //  GenericQueue 생성자를 통해, 배열 T의 크기를 설정.
        public GenericQueue(int length)
        {
            array = new T[length];
        }

        // Enqueue 메서드를 통해 값을 입력.
        public void Enqueue(T value)
        {
            array[++count] = value;
        }

        // Dequeue 메서드를 통해 값을 출력.
        public T Dequeue()
        {
            // count의 값이 0이면, default(T)를 반환합니다. 
            // default(T)는 형식 매개변수가 값 형식인 경우 0을 반환, 참조 형식인 경우 null을 반환합니다.
            return count == 0 ? default(T) : array[count--]; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericQueue<int> intData = new GenericQueue<int>(100);

            intData.Enqueue(100);
            intData.Enqueue(200);
            intData.Enqueue(300);

            Console.WriteLine(intData.Dequeue());
            Console.WriteLine(intData.Dequeue());
            Console.WriteLine(intData.Dequeue());

            intData.Enqueue(400);
            Console.WriteLine(intData.Dequeue());
            Console.WriteLine(intData.Dequeue());
        }
    }
}
