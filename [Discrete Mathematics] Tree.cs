using System;

namespace Math_Tree
{
    public class Program
    {
        public static int[] treeNum = new int[100];
        public const int LIMIT = 10;

        public static void Main()
        {
            for (int i = 1; i < LIMIT; i++)
            {
                int j = 1;

                int num = Convert.ToInt32(Console.ReadLine());

                while (treeNum[j] != 0)
                {
                    if(treeNum[j] > num)
                    {
                        j *= 2;
                    }
                    else
                    {
                        j = j * 2 + 1;
                    }
                }

                treeNum[j] = num;


                Console.WriteLine(j + " : " + treeNum[j]);
            }
        }
    }
}
