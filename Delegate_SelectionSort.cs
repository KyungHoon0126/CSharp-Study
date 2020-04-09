using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegate_SelectionSort
{
    class SortObject // 배열을 정렬할 수 있는 기능을 가진 타입 정의
    {
        int[] numbers;

        public SortObject(int[] numbers) // 배열을 생성자의 인자로 받아서 보관
        {
            this.numbers = numbers;
        }

        public delegate bool CompareDelegate(int arg1, int arg2);

        public void Sort(CompareDelegate compareMethod) 
        {                                               
            int temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                int lowPos = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (compareMethod(numbers[j], numbers[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }

        public void DIsPlay() // numbers 요소를 화면에 출력
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }
    }

    class Delegate_SelectionSort
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

            SortObject so = new SortObject(intArray);
            so.Sort(AscendingCompare); // 오름차순 정렬을 할 수 있는 메서드 전달
            so.DIsPlay();

            Console.WriteLine();

            so.Sort(DescendingCompare); // 내림차순 정렬을 할 수 있는 메서드 전달
            so.DIsPlay();
        }

        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }

        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }
    }
}
