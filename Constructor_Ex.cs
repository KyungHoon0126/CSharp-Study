using System;

namespace Test
{
    public class Cat
    {
        public  Cat() // Cat : 생성자, () : 매개변수목록
        {
            Name = "";
            Color = "";
        }

        //생성자도 여느 메소드와 마찬가지로 오버로딩 가능.

        public Cat(string _Name, string _Color) // 객체를 생성할 때 이름과 색을 입력받아 초기화 한다.
        {
            Name = _Name;
            Color = _Color;
        }

        public string Name;
        public string Color;
    }

    public class MainApp
    {
        private static void Main(string[] args)
        {
            Cat kitty = new Cat(); //Cat()
            kitty.Name = "키티";
            kitty.Color = "하얀색";

            Cat nabi = new Cat("나비", "갈색"); // Cat( sring _Name, string _Color )
        }
    }
}