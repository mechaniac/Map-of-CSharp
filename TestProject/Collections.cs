using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace NS_Coll
{
    public static class Coll
    {
        public static void Run()
        {
            var myArray = new int[3] {2,5,7};
            var newArray = myArray.Append(12);

            foreach(int i in myArray){Logger.Log(i);};
            foreach(int i in newArray){Logger.Log(i);};

            var myO = new C();
            Logger.Log(myO.GetType() == typeof(C));
            var al = new ArrayList() { 1, "Bb", myO };
            Logger.Log(al[1]?.GetType());
            al.Add(12);
            Logger.Log(al);

            foreach (object o in al)
            {
                Logger.Log(typeof(C));
            }

            Logger.Log("stringCollection");
            var sc = new StringCollection() { "Aa", "Bb", "Cc" };


            var l = new List<string>() { "Aa", "Bb", "Cc" };
            l.Insert(2, "Dc");
            Logger.Log(l.IndexOf("Aa"));
            l.RemoveAt(2);
            // l.TrimExcess
            Logger.Log(l[2]);
            foreach (string s in l) { Logger.Log(s); };

            Logger.Log("Stack");
            var stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");

            string res = stack.Pop();
            Logger.Log("popped: ", res);
            string peek = stack.Peek();
            Logger.Log("peeked: ", peek);

            foreach (string st in stack) { Logger.Log(st); };
            var scount = stack.Count;


            Logger.Log("Dictionary");
            string? myvalue;
            var d = new Dictionary<string, string>() { { "ab", "XY" }, { "ef", "ZZ" }, { "ad", "GH" } };
            d.Remove("ab");
            d.TryGetValue("ad", out myvalue);
            foreach (var oo in d) { Logger.Log(oo.Value); };

            Logger.Log("myValue=", myvalue);
            string? myValue = d["ef"];
            Logger.Log(myValue);

            Logger.Log(d.ContainsKey("das"));

            Logger.Log(d.Count);

            Logger.Log("HashSet");

            var hs = new HashSet<string>() { "ab", "cd", "ab", "JoejackJill" };

            foreach (string hss in hs) { Logger.Log(hss); };
            hs.Remove("ab");
            Logger.Log(hs.Contains("ab"));

            bool isLongerThan3(string inputS)
            {
                return inputS.Length > 3;
            }
            hs.RemoveWhere(isLongerThan3);

            foreach (string hss in hs) { Logger.Log(hss); };


            Logger.Log("sort array");
            var cArray = new char[3]{'c','c','a'};
            foreach(char cc in cArray){Logger.Log(cc);};
            Array.Sort(cArray);

            foreach(char cc in cArray){Logger.Log(cc);};
        }

        class C
        {

        }
    }
}