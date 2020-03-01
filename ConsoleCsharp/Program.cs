using System;
namespace ConsoleCsharp
{
    public class Program
    {
        static void Main()
        {
            const string ok = "ok";//const ok = "ok" will not work
            var o = "o";// static var o = "o" static modifier now allowed for var
            Console.WriteLine(o);
            Console.WriteLine(ok);

        }
    }
}
