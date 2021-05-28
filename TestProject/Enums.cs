using System;
namespace NS_Enums
{


    static class Enums
    {
        public static void Run()
        {
            E e = E.B | E.C;
            Es es = Es.B | Es.C;

            Logger.Log("E: ", e);
            Logger.Log((int)e);
            Logger.Log("Es: ", es.ToString());

            int x = 5|1;
            Logger.Log(x);
        }
    }

    
    public enum E
    {
        A=0,
        B=1,
        C=2,
        D=3,
        E=4,
        F=5,
        G=6
    }

    [Flags]
    public enum Es
    {
        None = 0,
        A = 1,
        B = 2,
        C = 4,
        D = 8
    }



}