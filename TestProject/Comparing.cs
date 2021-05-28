using System;
using System.Collections.Generic;

namespace NS_Comp{
    class Comp{
        public static void Run(){
            var aC = new C[5]{new C(){Name="Cc"},new C{Name="BB"},new C{Name="Fg"},new C{Name="Gg"},new C{Name="Aa"}};

            foreach(C c in aC){Logger.Log(c.Name);};
            Array.Sort(aC);
            Logger.Log("aC Sorted:");
            foreach(C c in aC){Logger.Log(c.Name);};

            Logger.Log("D-------------");
            var aD = new D[5]{new D(){Name="Cc"},new D{Name="BB"},new D{Name="Fg"},new D{Name="Gg"},new D{Name="Aa"}};
            
            foreach(D d in aD){Logger.Log(d.Name);};
            Array.Sort(aD, new DComparer());
            Logger.Log("aC Sorted:");
            foreach(D d in aD){Logger.Log(d.Name);};
            
        }

        class C :IComparable<C>{
 
            public string Name;

            public int CompareTo(C? c)
            {
                return Name.CompareTo(c.Name);
            }


        }

        public class D{
            public string Name;
        }

        public class DComparer : IComparer<D>
        {
            public int Compare(D? x, D? y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}