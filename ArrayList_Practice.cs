using System.Collections;
using static System.Console;

namespace ArrayList_Practice
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList list = null;
            list = new ArrayList();

            WriteLine("준비물 리스트");

            list.Add("1. Pencil");
            list.Add("2. Eraser");
            list.Add("3. Ruler");
            list.Add("4. Pen");
            list.Add("5. Tape");

            WriteLine($"Count : {list?.Count}");

            WriteLine($"{list[0]}");
            WriteLine($"{list[1]}");
            WriteLine($"{list[2]}");
            WriteLine($"{list[3]}");
            WriteLine($"{list[4]}");
        }
    }
}