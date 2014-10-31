using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMWork;
namespace CMConsole
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<int, string> { { 3, "devidebythree" }, { 5, "devidebyfive" }, { 10, "devidebyten" } };
            CMWork.CMWork.DevideAndPrint(1, 100, dict);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
