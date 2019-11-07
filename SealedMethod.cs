using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_SealedMethod
{
    class Base
    {
        public virtual void SealMe()
        {

        }
    }

    class Derived : Base
    {
        // sealed 키워드를 이용하여 virtual로 선언된 가상 메소드를 오버라이딩한 버전의 메소드만 봉인이 가능하다.
        public sealed override void SealMe()
        {
            
        }
    }

    class WantToOverride : Derived
    {
        public override void SealMe()
        {

        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
        }
    }
}
