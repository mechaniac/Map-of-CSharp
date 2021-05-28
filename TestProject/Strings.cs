using System;


class Stringmethods
{

    static void Do()
    {


        string s = "Ab cd";



        Log(s.Length);
        Log(s[0]);
        // Log(s.Split(' '));

        var sA = s.Split(' ');
        foreach (string e in sA)
        {
            Log("part", e);
        }

        Log(s.Substring(2));
        Log(s.Substring(1, 2));
        Log(s.IndexOf('c'));
        Log("starts with: ");
        Log(s.StartsWith('a'));
        Log(s.EndsWith('z'));
        Log(s.Contains("Ab"));

        Log("  xxx  ".Trim());
        Log(s.TrimStart('A'));
        Log(s.ToUpper());
        Log(s.ToLower());
        Log(s.Insert(2, "xy"));
        Log(s.Replace("Ab", "cd"));

        var az = new string[] { "ab", "cd", "ef" };
        string[] ass = { "ab", "cd", "ef" };
        Log(String.Concat(s, " ef"));
        Log(String.Join("x", new string[] { "a", "b", "c" }));
        Log(String.Empty);


        Log(int.Parse("12"));
        Log(DateTime.Parse("16 May 1978"));


        Log("type: a nr");
        string? input = Console.ReadLine();
        int nr;
        if (int.TryParse(input, out nr))
        {
            { Log($"yout tyoped {nr}"); }
        }
        else
        {
            Log("maa");
        }

        int nr2;
        int.TryParse("23", out nr2);

    }



    static void Log<T>(T p)
    {
        Console.WriteLine(p);
    }

    static void Log<T>(string pp, T p)
    {
        Console.Write(pp);
        Console.WriteLine(p);
    }

}