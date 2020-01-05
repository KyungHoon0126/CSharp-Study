using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Property
{
    class Circle
    {
        double pi = 3.14;

        // 프로퍼티 이용
        public double Pi
        {
            get { return pi; }
            set { pi = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Pi = 3.141592; // set으로 사용
            double piValue = c.Pi; // get으로 사용
        }
    }
}
