using System;

namespace NS_Attr
{
    public static class Attr
    {
        public static void Run()
        {

        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class A : Attribute
    {
        public string? N { get; set; }
    }

    [A(N="abc")]
    public class C
    {

    }
}