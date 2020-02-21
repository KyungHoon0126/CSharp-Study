using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Transformation_between_Classes
{
    public class Currency
    {
        decimal money;
        public decimal Money { get { return money; } }

        public Currency(decimal money)
        {
            this.money = money;
        }
    }

    public class Won : Currency
    {
        public Won(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Won";
        }
    }

    public class Dollar : Currency
    {
        public Dollar(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Dollar";
        }

        // 개발자가 의도한 형변환만 가능하도록 제한을 걸고 싶을 때 : implicit 대신 explicit 키워드 사용
        static public explicit operator Won(Dollar dollar)
        {
            return new Won(dollar.Money * 1000m);
        }
    }

    public class Yen : Currency
    {
        public Yen(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Yen";
        }

        // Yen에서 Won을 대입하고 싶을 때 implicit 연산자 사용
        static public implicit operator Won(Yen yen)
        {
            return new Won(yen.Money * 13m); // 1엔당 13원으로 가정
        }
    }
    class ClassTransformation
    {
        static void Main(string[] args)
        {
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(13);


            Yen yen2 = new Yen(100);
            Won won2 = yen2; // 암시적(implicit) 형변환 가능
            Won won3 = (Won)yen2; // 명시적(explicit) 형변환 가능
            Console.WriteLine(won2); // 출력 결과 : 1300Won

            Dollar dollar2 = new Dollar(1);
            //Won won4 = dollar; 암시적(implicit) 형변환 불가능
            Won won5 = (Won)dollar2; // 명시적(explicit) 형변환 가능
            Console.WriteLine(won2); // 출력 결과 : 1000won
        }
    }
}
