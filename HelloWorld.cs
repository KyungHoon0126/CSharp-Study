using System;

// using은 키워드 중 하나이다.
// System은 숫자, 텍스트와 같은 데이터를 다룰 수 있는 기본적인 데이터 처리 클래스를 비롯하여, C#코드가 기본적으로 필요로 하는 클래스를 담고있는 네임스페이스이다.
// 따라서 using System이라고 한 것은 System 네임스페이스 안에 있는 클래스를 사용하겠다고 컴파일러에게 알리는 역할.

namespace BrainCSharp

// namepsace는 성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 델리게이트, 열거형식등을 하나의 이름 아래 묶는 역할.
// namespace BrainCSharp은 BrainCSharp이라는 네임스페이스를 만들고, 그 뒤에 따라오는 괄호 {}는 BrainCSharp 네임스페이스에 HelloWorld 클래스를 담는다.

// 다른 네임스페이스에서 HelloWorld 클래스를 사용하려면 using BrainCSharp;를 이용해서 BrainCSharp 네임스페이스를 참조
// 또는 BrainCSarp.HelloWorld처럼 클래스가  소속되어 있는 네임스페이스와 클래스의 이름을 붙여줘야 한다.
{
    class HelloWorld

    // class는 C# 프로그램을 구성하는 기본 단위로서 데이터와 데이터를 처리하는 기능(이것을 메소드(Method)라고 부른다.)이다.

    {
        //  프로그램 실행이 시작되는 곳

        static     void       Main       (string[] args) // 메소드, 프로그램의 진입점

        // 메소드라 함은, 쉽게 말해 객체 지향 프로그래밍 세계에서 함수를 일컫는 말.
        // 객체 지향 프로그래밍에서 모든 것이 객체이고, 함수는 객체의 일부로서 존재.   

        // static은 한정자로써, 메소드나 변수 등을 수식한다.
        // void는 반환 형식, void = 비어 있는 이란 뜻, 어떤 결과도 반환 x
        // Main은 메소드의 이름
        // (매개변수) 메소드 뒤에 입력되는 ()안의 코드는 매개변수이다.

        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, {0}!", args[0]);
        }
    }
}