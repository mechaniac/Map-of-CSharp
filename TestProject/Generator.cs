using System.Collections.Generic;

namespace NS_Gen
{
    public static class Gen
    {
        public static void Run()
        {


            l = new List<int>() { 1, 2, 3 };

            Logger.Log(total());
        }
        static IEnumerable<int>? l;
        static IEnumerable<int> total()
        {
            int t = 0;

            foreach (int i in l!)
            {
                t+= i;
                yield return t;
            }
        }
    }


}