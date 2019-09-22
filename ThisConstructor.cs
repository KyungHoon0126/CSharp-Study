using System;

namespace Constructor
{
    class MyClass
    {
        private int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MhyClass{b}");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass{b}, {c}");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }

    class MainApp
    {
        public static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass();
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass();
            c.PrintFields();
            Console.WriteLine();


        }
    }
}