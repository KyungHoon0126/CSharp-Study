using System;

public class Global
{
    public static int Count = 0;
}

public class ClassA
{
    public ClassA()
    {
        Global.Count++;
    }
}

public class ClassB
{
    public ClassB()
    {
        Global.Count++;
    }
}

public class MainApp
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Globla.Count : {Global.Count}");

        new ClassA();
        new ClassA();
        new ClassB();
        new ClassB();
        
        Console.WriteLine($"Global.Count : {Global.Count}");
    }
    
}