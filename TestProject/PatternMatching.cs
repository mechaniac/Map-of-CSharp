using System;


public static class PatternMatching
{
    public static void Do()
    {
        // var p = new Point();
        // var p2 = new Point { X = 3, Y = 4 };
        // Logger.Log(p);

        int i = 12;
        Test(i);
        SwitchTest(i);
    }


    static void Test(object o)
    {
        if (o is int i)
        {
            Logger.Log(i);
        }
    }

    static void SwitchTest(object o)
    {
        switch (o)
        {
            case int i:
                Logger.Log(i);
                break;
        }
    }
}


public struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public override string ToString() =>
        $"({X}, {Y})";
}