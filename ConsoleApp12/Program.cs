using System;
using static System.Console;
using System.Threading;
using System.IO;
namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] ages)
        {
            Worker w = new Worker("33","asdasd","sdaasd","sdasfdas","asdasd","asdasd");
            WriteLine(w.PrintID());

            w.Save();
            w.NewSave("Toxa", "asdasd", "asdas", "sadasd", "dasasd", "xcvzxc");
            //w.Delete();


               
            

        }
    }
}
