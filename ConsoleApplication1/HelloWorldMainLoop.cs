using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HelloWorldMainLoop
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Hello world");
                String command = Console.ReadLine();
                if ("quit".Equals(command))
                {
                    break;
                }
            }
        }
    }
}
