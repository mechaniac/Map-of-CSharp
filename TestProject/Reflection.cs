using System;
using System.Reflection;

namespace NS_Refl{
static class Refl{
    public static void Run(){


        C o = new C(1);
        
        Logger.Log(o.GetType());
        Type to = o.GetType();

        Assembly info = to.Assembly;
        Logger.Log(info);

        Type tC = typeof(C);
        Logger.Log("tC= ", to);
        Type? t = Type.GetType("NS_Refl.C");
        Logger.Log("t= ", t);

        PropertyInfo[] pi = t!.GetProperties();
        Logger.Log("------");
        Logger.Log("propertyinfo");
        foreach(var p in pi){
            Logger.Log(p);
        }

        FieldInfo[] fi = t.GetFields();
        Logger.Log("------");
        Logger.Log("fieldinfo");
        foreach(var p in fi){
            Logger.Log(p);
        }

        MethodInfo[] mi = t.GetMethods();
        Logger.Log("------");
        Logger.Log("methodinfo");
        foreach(var p in mi){
            Logger.Log(p);
        }

        MemberInfo[] memi = t.GetMembers();
        Logger.Log("------");
        Logger.Log("memberinfo");
        foreach(var p in memi){
            Logger.Log(p);
        }
    }


}
    class C:A, IContract{
        public C(int B){

            this.B = B;
        }
        public string? A{get; set;}
        public int B { get; }
        public int BB => B+B;
        public int X = 2;
        public override void Ma()
        {
            throw new NotImplementedException();
        }

        public override void Mv()
        {
            throw new NotImplementedException();
        }

        void M(){
            Console.Write("hi");
        }

        public void MI(int p)
        {
            throw new NotImplementedException();
        }
    }

    abstract class A{
        public abstract void Ma();

        public virtual void Mv(){}

    }
    interface IContract{
        void MI(int p);
    }
}