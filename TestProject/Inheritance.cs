using System;

namespace NS_inherit
{
    public static class Inher
    {
        public static void Run()
        {
            Console.WriteLine("Ab----new-----");
            A ab = new B();
            ab.Do();


            // Console.WriteLine("Bb---------");
            // B bb = new B();
            // bb.Do();

            Console.WriteLine("Ac----override-----");
            A ac = new C();
            ac.Do();

            // Console.WriteLine("Cc---------");
            // C cc = new C();
            // cc.Do();

        }

        class A
        {
            public virtual void Do()
            {
                Console.WriteLine("Doing A");
            }
        }

        class B : A
        {
            public new void Do()
            {
                // base.Do();
                Console.WriteLine("Doing B");
            }
        }

        // class BB:C{
        //     public sealed void Do(){

        //     }
        // }
        // class BBB:BB{
        //     public new void Do(){

        //     }
        // }

        class C : A
        {
            public override void Do()
            {
                // base.Do();
                Console.WriteLine("Doing C");
            }
        }
    }
}