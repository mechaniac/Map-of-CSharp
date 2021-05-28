using System;
using System.Reflection;

namespace NS_Events
{
    class Events
    {


        public static void Run()
        {

            
            var o = new C();
            o.e += C_e;
            o.Do();
        }
        static void C_e()
        {
            Logger.Log("done");
        }


    }
    public delegate void E();
    class C
    {
        public void Do()
        {
            Console.WriteLine("doing");
            Done();
        }

        private void Done()
        {
            e?.Invoke();
        }

        public event E? e;
    }
}