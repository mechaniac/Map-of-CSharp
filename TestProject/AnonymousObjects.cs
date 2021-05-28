static class Anon
{
    public static void Do()
    {
        
        Logger.Log(GetO());

        var t = GetO();
        Logger.Log(t.GetType());

        (int id, string n)tt=(1,"xy");
        Logger.Log(tt.n);

        (int a, string b) = t;
        Logger.Log(b);
    }

    static (int, string) GetO(){
        return (1, "xy");
    }

    

}