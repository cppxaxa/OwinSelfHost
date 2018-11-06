using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Microsoft.Owin.Hosting.WebApp.Start<Startup>("http://localhost:2259"))
            {
                Console.WriteLine("Open the address in the browser or");
                Console.WriteLine("Press any key to continue..");
                Console.ReadLine();
            }
        }
    }
}
