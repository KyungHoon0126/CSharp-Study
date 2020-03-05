using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int GetResultDelegate(); // int를 반환하고 매개변수가 없는 델리게이트 타입을 정의

class Target
{
    public void Do(GetResultDelegate getResult)
    {
        Console.WriteLine(getResult()); // 콜백 메서드 호출
    }
}

class Source
{
    public int GetResult()
    {
        return 10;
    }

    public void Test()
    {
        Target target = new Target();
        target.Do(new GetResultDelegate(this.GetResult));
    }
}

namespace CSharp_CallBack_using_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source();
            source.Test();
        }
    }
}
