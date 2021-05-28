using System;
namespace NS_Exc
{
    public static class Exec
    {
        public static void Run()
        {
            var o = new C();

            try
            {
                Logger.Log(o.Use(1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally{
                Logger.Log("always");
            }

            Console.WriteLine("prog continues");
        }

        class C
        {
            string[] a = { "one", "two", "three" };
            public string Use(int i)
            {
                if (i >= a.Length)
                {
                    throw new E("doesnt exist");
                }
                else { return a[i]; }
            }
        }

        class E : Exception
        {
            public E() : base()
            {

            }
            public E(string msg) : base(msg)
            {

            }
            public E(string msg, Exception ex) : base(msg, ex)
            {

            }
        }
    }
}