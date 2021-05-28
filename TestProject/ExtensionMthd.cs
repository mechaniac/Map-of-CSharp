namespace NS_Ext
{
    public static class Ext
    {
        public static void Run()
        {
            var o = new C() { P = 12 };
            Logger.Log(o.ExtM());
        }

        public class C
        {
            public int P { get; set; }
        }

        public static int ExtM(this C c)
        {
            return c.P * 2;
        }
    }
}