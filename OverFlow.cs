using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverFlow
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue; // uint의 최대값

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a); // 오버플로우된 변수는 a는 0을 가진다. uint가 가질 수 있는 최저값으로 돌아온다.

            // 각 데이터 형식의 최대값을 넘어가는 데이터를 저장할 때는 오버플로우가 일어나지만 최저값보다 작은 데이터를 저장하면 언더플로우가 일어난다.
        }
    }
}

/*---------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

namespace OverFlowEx
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}