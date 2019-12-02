using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_GenericMethod
{
    public class Utility
    {
        //public static void WriteLog(object item)
        //{
        //    string output = string.Format("{0} : {1}", DateTime.Now, item);
        //    Console.WriteLine(output);
        //}

        public static void WriteLog<T>(T item)
        {
            string output = string.Format("{0} : {1}", DateTime.Now, item);
            Console.WriteLine(output);
        }

        public static void Main(string[] args)
        {
            // WriteLog(10);

            // 방법 1
            Utility.WriteLog<bool>(true);
            Utility.WriteLog<int>(0x05);
            Utility.WriteLog<float>(3.14159f);
            Utility.WriteLog<string>("test");


            // 방법 2
            Utility.WriteLog(true);
            Utility.WriteLog(0x05);
            Utility.WriteLog(3.14159f);
            Utility.WriteLog("test");
        }
    }
}
