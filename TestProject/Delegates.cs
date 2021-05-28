using System;
namespace NS_Dele{
    class Dele{
        public static void Run(){
            D d1 = new D(M);
            D d2 = delegate(int i){return i.ToString();};
            D d3 = i => i.ToString();

            d1 += d2 += d3;
            string s = "a";
            s += d1(2);
            Logger.Log(s);
        }

        delegate string D(int i);

        static string M(int i){
            return i.ToString();
        }
    }
}