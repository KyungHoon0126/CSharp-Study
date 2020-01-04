using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inheritance_Casting
{
    public class Computer
    {
        // bool powerOn; 기본적으로 private 접근 제한자가 적용.
        protected bool powerOn; // protected 사용시 자식 클래스 내에서는 허용.
        public void Boot() { }
        public void Shutdown() { }
        public void Reset() { }
    }
}
