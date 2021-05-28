namespace NS_Generic{
    class Program{
        public static void Run(){

            int x = 2;
            int y = 3;
            Swap(ref x,ref y);
        }

        static void Swap<T>(ref T a, ref T b){
            T temp = a;
            a = b;
            b = temp;
        }
    }
}