using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_yield
{
    public class Program
    {
       public static void Main(string[] args)
        {
            //int? i = null;
            //i = 101;
            //int z = i.Value;

            //Nullable<int> j = null;
            //j = 10;
            //int k = j.Value;

            //Console.WriteLine(z);
            //Console.WriteLine(k);

            string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            string[,,] DeveloperInfo = { { { "김경훈", "Window", "C#" } }, { { "Kevin", "Server", "JS" } } };
            for(int i = 0; i < DeveloperInfo.Length; i++)
            {
                Console.WriteLine(DeveloperInfo);
            }
        }
    }
}
