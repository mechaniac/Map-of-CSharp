using System;

namespace NS_Ev2{
    class Ev{
        public static void Run(){
            Ev ev = new Ev();

            ev.MyEvent += new EventHandler(ev.DoNothing);
            ev.MyEvent -= null;
        }   
        void DoNothing(object sender, EventArgs e){}

        public event EventHandler MyEvent{
            add{

            }
            remove{
                
            }
        }
        public event EventHandler? H;
    }


    class Program{
        public static void Run(){
            P o = new P();
            o.PCompleted += Handle;
            o.StartP();
        }
        static void Handle(object sender, EventArgs e){
            Logger.Log("Done");
        }
    }
    class P{
        public void StartP(){
            Logger.Log("Doing");
            OnPCompleted(EventArgs.Empty);
        }
        void OnPCompleted(EventArgs e){
            PCompleted?.Invoke(this, e);
        }
        public event EventHandler? PCompleted;
    }
}