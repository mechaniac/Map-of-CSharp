namespace NS_Typesisas
{
    class Program
    {
        public static void Run()
        {
            A a = new A();
            C1 c1 = new C1();
            A ac = c1;


            C2 c2 = (C2)a;
            

            // C2 c2 = c1 is C2;
            Logger.Log("ac type: ", ac.GetType());
        }

         class A
        {
            public virtual void Mv(){
                Logger.Log("A");
            }
        }

        class C1 : A
        {
            public override void Mv()
            {
                Logger.Log("C1:A");
            }
        }
        
        class C2 : A
        {
            public override void Mv()
            {
                Logger.Log("C2:A");
            }
        }
    }
}