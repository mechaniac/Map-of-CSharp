using System;
using System.Collections.Generic;

static class Logger
{
    public static void Log<T>(T p)
    {
        Console.WriteLine(p);
    }

    static void DoT(){
        Console.WriteLine("xx");
    }

    public static void Log<T>(string pp, T p)
    {
        Console.Write(pp);
        Console.WriteLine(p);
    }
    public static void Log<T>(T[] p){
        int i = 1;
        foreach(T t in p){
            Console.Write($"{i++} :");
            Console.WriteLine(t);
        }
    }
    public static void Log<T>(IEnumerable<T> p){
        int i = 1;
        foreach(T t in p){
            Console.Write($"{i++} :");
            Console.WriteLine(t);
        }
    }
}
