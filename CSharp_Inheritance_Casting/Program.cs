using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inheritance_Casting
{
    public class DeviceManger
    {
        public void TurnOff(Computer device)
        {
            device.Shutdown();
        }
    }
}

namespace CSharp_Inheritance_Casting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Desktop desktop = new Desktop();
            Netbook netbook = new Netbook();

            DeviceManger manger = new DeviceManger();
            manger.TurnOff(notebook);
            manger.TurnOff(desktop);
            manger.TurnOff(netbook);


            Computer[] machines = new Computer[] { new Notebook(), new Desktop(), new Netbook() }; // 자식 클래스의 인스턴스를 부모 객체의 배열에 담을 수 있는 이유 → 암시적 형변환

            DeviceManger deviceManger = new DeviceManger();

            foreach (Computer device in machines)
            {
                deviceManger.TurnOff(device);
            }
        }
    }
}
