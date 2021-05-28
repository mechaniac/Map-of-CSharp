using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace NS_Serialize
{
    public static class Serialize
    {
        public static void Run()
        {
            var o = new C { N = "abc", I = 123 };


            var s = new XmlSerializer(typeof(C));

            using(TextWriter w = new StreamWriter(@"C:\WORK\_PROJECTS\CODING_01\C_Sharp\Test_01\TestProject\MySerialzedFile.xml"))
            {s.Serialize(w, o);}

            TextReader r = new StreamReader(@"C:\WORK\_PROJECTS\CODING_01\C_Sharp\Test_01\TestProject\MySerialzedFile.xml");
            o = (C)s.Deserialize(r);
            
            r.Close();

            Logger.Log("result: ", o?.ToString());
        }
    }

    [Serializable]
    public class C : ISerializable
    {
        public string? N { get; set; }
        public int? I { get; set; }

        public C() { }

        public C(SerializationInfo info, StreamingContext context)
        {
            N = (string)info.GetValue("N", typeof(String));
            I = (int)info.GetValue("I", typeof(Int32));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("N", N);
            info.AddValue("I", I);
        }

        public override string ToString()
        {
            return $"{N}, {I}";
        }
    }
}