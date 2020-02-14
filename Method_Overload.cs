using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Method_Overload
{
    // 오버로가 없다면 유사한 메서드를 여러 개 정의 해야 한다.

    //class Mathematics
    //{
    //    public int AbsInt(int value)
    //    {
    //        return (value >= 0) ? value : -value;
    //    }

    //    public double AbsDouble(double value)
    //    {
    //        return (value >= 0) ? value : -value;
    //    }

    //    public decimal AbsDecimal(decimal value)
    //    {
    //        return (value >= 0) ? value : -value;
    //    }
    //}

    // 오버로드는 동일한 이름의 메서드로 일관성 있게 클래스 작성 가능.
    class Mathematics
    {
        public int Abs(int value)
        {
            return (value >= 0) ? value : -value;
        }

        public double Abs(double value)
        {
            return (value >= 0) ? value : -value;
        }

        public decimal Abs(decimal value)
        {
            return (value >= 0) ? value : -value;
        }
    }

    class Method_Overload
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            Console.WriteLine(math.Abs(-5));
            Console.WriteLine(math.Abs(-10.052));
            Console.WriteLine(math.Abs(20.01m));
        }
    }
}

