using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Type type = program.GetType();

            Console.WriteLine(type.FullName);
            Console.WriteLine(type.IsClass);
            Console.WriteLine(type.IsArray);


            int n = 5;
            string txt = "text";

            Type intType = n.GetType();

            Console.WriteLine(intType.FullName);
            Console.WriteLine(txt.GetType().FullName);


            Type type2 = typeof(double);
            Console.WriteLine(type2.FullName);

            Console.WriteLine(typeof(Int16).FullName);
        }
    }
}
