using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 제네릭 형식 매개변수에 대한 제약조건, where
/// </summary>

// 제네릭 클래스에 사용된 형식 매개변수에 제약조건 명시한 경우.
public class MyClass<T> where T : ICollection
{
}

// 형식 매개변수에 2개 이상의 제약 조건을 명시한 경우.
public class MyType<T> where T : ICollection, IConvertible
{
}

// 형식 매개변수 2개에 대해 제약 조건을 명시한 경우.
public class Dict<K, V> where K : ICollection where V : IComparable
{
}




/// <summary>
/// 제네릭 형식 매개변수에 대한 특별한 제약조건
/// </summary>


// T 형식 매개변수는 반드시 ※ 값 형식※ 만 가능.
public class Special1
{
    public static int GetSizeof<T>(T item) where T : struct
    {
        // Marshal : 값 형식의 바이트 크기를 반환하는 Sizeof 메서드, 제네릭 메서드를 만들면 모든 값 형식의 크기를 구한다.
        // ※ 값 형식만 사용 가능 ※
        return Marshal.SizeOf(item);
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(GetSizeof(0.5f)); // float : 4
    //    Console.WriteLine(GetSizeof(4m)); // decimal : 16
    //    Console.WriteLine(GetSizeof("My")); // 참조형 변수 사용, 값 형식이 아니므로 오류 발생.
    //}
}



// T 형식 매개변수는 반드시 참조 형식만 가능.
// 타입이 null인 경우 체크 -> 예외 발생 메서드.
public class Special2_1
{
    public static void CheckNull<T>(T item)
    {
        if (item == null)
        {
            throw new ArgumentException();
        }
    }

    //public static void Main(string[] args)
    //{
    //    int a = 5;
    //    string b = "My";

    //    CheckNull(a); // 컴파일 : 정상
    //    CheckNull(b); // 컴파일 : 정상
    //}
}


// 모든 값 형식이 null 상태를 갖지는 않으므로, 항상 참조 형식에 적용.
public class Special2_2
{
    public static void CheckNull<T>(T item) where T : class
    {
        if(item == null)
        {
            throw new ArgumentException();
        }
    }

    //public static void Main(string[] args)
    //{
    //    int a = 5;
    //    string b = "My";
        
    //    CheckNull(a);  // 컴파일 : 오류
    //    CheckNull(b);  // 컴파일 : 정상
    //}
}



// T 형식 매개변수의 타입은 반드시 매개변수 없는 공용 생성자 포함, 즉 기본 생성자 정의 필요.
// T 타입의 객체를 제네릭 메서드/클래스 내부에서 new 연산자를 통해 생성할 때 사용.
// ex : 메서드에 전달된 인자가 null인 경우 새롭게 생성해서 반환하는 메서드를 만들 때.

// T 형식에는 절대로 기본 생성자가 없는 타입을 지정해서는 안된다고 알려줘야 한다 -> new() 조건

public class Special3
{
    public static T AllocateIfNull<T>(T item) where T : class, new()
    {
        if(item == null)
        {
            item = new T();
        }

        return item;
    }
}



// // T 형식 매개변수는 반드시 "U 형식 인수"에 해당하는 타입 or 그것으로부터 상속받은 클래스만 가능.
//public class Special4<T> where T : U
//{
//}

    

// 형식 매개변수 2개를 사용한 제약조건
public class BaseClass { }
public class DerivedClass : BaseClass { }


public class Utility
{
    public static T Allocate<T, V>() where V : T, new()
    {
        // T : BaseClass, V : DerivedClass
        // Allocate 메서드 : DerivedClass를 new로 할당해 BaseClass로 형 변환해서 반환하는 역할.
        return new V();
    }
}


namespace Generic_Where
{
    class Generic_Where
    {
        static void Main(string[] args)
        {
            BaseClass dInst = new DerivedClass();
        }
    }
}
