using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit
{
    internal class CommonTools
    {
        public static void Continue(string output)
        {
            Console.WriteLine($"----------------------------------\n{output}\nPress \"Z\" to continue");
            Console.ReadKey();
            Program.ReloopMain();
        }
    }
}
