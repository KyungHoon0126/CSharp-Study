﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Capsule
{
    class Circle
    {
        double pi = 3.14;

        double GetArea(double radius)
        {
            return radius * radius * pi;
        }

        public void Print(double value)
        {
            Console.WriteLine(GetArea(value));
        }                                                                                                                      
    }

    class Program 
    {
        static void Main(string[] args)
        {
            Circle o = new Circle();
            o.pi = 6.28; // 컴파일 오류 발생 : 접근 불가(inaccessible)
            o.GetArea(10); // 컴파일 오류 발생 : 접근 불가(inaccessible)

            o.Print(10); // public 멤버이므로 호출 가능 
        }
    }
}
