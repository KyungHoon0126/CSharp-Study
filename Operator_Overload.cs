using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Operator_Overload
{
    public class Kilogram
    {
        double mass;

        public Kilogram(double value)
        {
            this.mass = value;
        }

        public Kilogram Add(Kilogram target)
        {
            return new Kilogram(this.mass + target.mass);
        }

        public override string ToString()
        {
            return mass + "kg";
        }

        // 연산자 오버로드
        public static Kilogram operator +(Kilogram op1, Kilogram op2)
        {
            return new Kilogram(op1.mass + op2.mass);
        }
    }

    class Operator_Overload
    {
        static void Main(string[] args)
        {
            // Kilogram 타입 사용 예제
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1.Add(kg2);
            Console.WriteLine(kg3);

            Kilogram kg4 = new Kilogram(5);
            Kilogram kg5 = new Kilogram(10);

            Kilogram kg6 = kg4 + kg5;
            Console.WriteLine(kg6);
        }
    }
}
