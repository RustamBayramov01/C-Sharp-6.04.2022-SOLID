using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SinglePrinciple { }

    public static class Size
    {
        public static bool Check() { return true; }
    }

    public static class GetDressed
    {
        public static void Decision()
        {
            if (Size.Check()) { Console.WriteLine("Large"); }
            else { Console.WriteLine("Small"); }
        }
    }
}
