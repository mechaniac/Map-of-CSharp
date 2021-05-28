using System;

namespace NS_Range{
    class Program{
        public static void Run(){
            var a = new char[]{'a','b','c','d','e'};

            Range r =0..4;

            foreach(char c in a[r]){Logger.Log(c);};
            Logger.Log("-----------");
            foreach(char c in a[^3..^0]){Logger.Log(c);};
        }
    }
}