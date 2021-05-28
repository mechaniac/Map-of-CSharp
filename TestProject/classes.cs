using System;

namespace NS_classes{

    class Program{
        public static void Run(){
            var o = new MyC(3);
            Logger.Log(MyC.c);
            Logger.Log(o.i);
        }
    }
    abstract class BaseC{

        public BaseC(){

        }
        public abstract void m1();

        public virtual void m2(){

        }
        
    }

    class C: BaseC{

        public C(int p) : base(){
            
            id = p;
        }
        public override void m1(){

        }
        public sealed override void m2()
        {
            base.m2();
        }

        public int BB=> id+id;

        public int id {get;}=12;

        public void log(){
            Console.WriteLine($"this id = {id}");
        }
    }

    class MyC{

        public const int c = 2;
        public readonly int i;
        public MyC(int _i){
            i = _i;
        }
    }

    }