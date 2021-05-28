using System;
static class ShallowCopy{

    public static void Run(){
        
        var a = new C[3];

        a[0] = new C(1, "joe");
        a[1] = new C(2, "zoe");
        a[2] = new C(3, "boe");

        var a2 = (C[])a.Clone();

        a[1].n = "xxx";
        L(a2[1].n);
    }

    static void L<T>(T p){
        Console.WriteLine(p);
    }

    public class C{
        public C(int id, string n){
            this.id = id;
            this.n = n;
        }
        public int id;
        public string n;
    }
}