using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MethodHiding
{
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base
    {
        // new : CLR에 의해 기반 클래스에서 구현된 버전의 메소드를 감추고, 파생 클래스에서 구현된 버전만을 보여준다.
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base baseOBj = new Base();
            baseOBj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            // new 한정자로 수식을하여 메소드를 숨길수 있지만, 객체를 선언하면 접근이 가능하다.
            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }
}
