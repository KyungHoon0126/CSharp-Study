using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inheritance_Casting
{
    public class Notebook : Computer
    {
        bool fingerScan; // Notebook 타입에 해당하는 멤버만 추가
        public bool HasFingerScanDevice() { return fingerScan; }

        public void CloseLid()
        {
            Shutdown(); // Notebook에서 추가된 메서드 내에서 부모의 메서드 호출
        }
    }
}
