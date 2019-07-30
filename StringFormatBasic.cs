using System;
using static System.Console;

namespace StringFormatBasic
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            string fmt = "{0, -20} {1, -15} {2, 30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "DGSW", "Kyunghoon Kim", "HightScoolFirstGrade");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Lanugage");

            // 서식 지정자
            // 서식 지정자 : D , 대상 서식 : 10진수, 설명 : 입력된 수를 10진수로 서식화한다. ex) WriteLine("{0 : D}", 0xFF); //255
            // 서식 지정자 : X , 대상 서식 : 16진수, 설명 : 입력된 수를 16진수로 서식화한다. ex) WriteLine("{0 : X}", 0xFF); // 0xFF
            // 서식 지정자 : N , 대상 서식 : 콤마(,)로 묶어 표현한 수, 설명 : 입력된 수를 콤마로 구분하여 출력한다. ex) WriteLine("{0 : N}", 123456789); // 123, 456, 789.00
            // 서식 지정자 : E , 대상 서식 : 지수, 설명 : 입력된 수를 지수 표기로 서식화 한다. ex) WriteLine("공학 : {0, E}", 123.456789; // 1.234568E+002 
        }
    }
}