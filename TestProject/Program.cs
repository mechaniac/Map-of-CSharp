using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;

class Program
{

    static void Main()
    {
        // PatternMatching.Do();
        // Anon.Do();
        // NS_Refl.Refl.Run();
        // NS_Enums.Enums.Run();
        // NS_Attr.Attr.Run();
        // NS_Async.Async.Run();
        // NS_Serialize.Serialize.Run();
        // NS_Coll.Coll.Run();
        NS_Range.Program.Run();
        // NS_Comp.Comp.Run();
        // NS_inherit.Inher.Run();
        // NS_Gen.Gen.Run();
        // NS_Dele.Dele.Run();
        // NS_Exc.Exec.Run();
        // NS_Ext.Ext.Run();
        // NS_Events.Events.Run();
        // S s;
        // s.x = 2;
        // s = new S(2,3);
        // Console.WriteLine(s.x);
        // Console.WriteLine(s.y);
        // C c;
        // c = new C(3);
        // c.x = 2;
        // Console.WriteLine(c.y);
        // S s = new S();
        // S s2 = new S(2,3);
        // S s3 = new S {x=2,y=3};

        // Logger.Log(s);
        // Logger.Log(s2);
        // Logger.Log(s3);

        
        // switch()
    }
    // struct S{
    //     public int x;
    //     public int y;
    //     public S(int _x, int _y){
    //         this.x = _x;
    //         y = _y;
    //     }

    //     public override string ToString(){
    //         return $"({x},{y})";
    //     }
    // }

    // class C{
    //     public int x;
    //     // public int y;
    //     public C(int _X){
    //         x=_X;
    //     }
    // }


    // static void Log<T>(T p)
    // {
    //     Console.WriteLine(p);
    // }

    // static void Log<T>(string pp, T p)
    // {
    //     Console.Write(pp);
    //     Console.WriteLine(p);
    // }


}

// class myBase{

// }

// class b1:myBase{}
// class b2:myBase{}

// class B
// {
//     public int a;

//     public static B operator +(B a, B b)
//     {
//         B c = new B();
//         c.a = a.a + b.a;
//         return c;
//     }
// }



