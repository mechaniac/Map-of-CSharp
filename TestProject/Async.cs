using System.Threading.Tasks;

namespace NS_Async
{

    public static class Async
    {
        public static async void Run()
        {
           await FAsync();
        }

        static async Task FAsync(){
            Task<R> tr = Task.Run(()=>M());
            var rr = await tr;
            R r = await Task.Run(()=>M());
        }


        static R M()
        {
            return new R();
        }
    }



    struct R
    {

    }
}