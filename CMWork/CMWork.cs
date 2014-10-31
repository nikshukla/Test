using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMWork
{
    public class CMWork
    {
        public static bool DevideAndPrint(int from, int to, Dictionary<int, string> numbersWords)
        {
            if (from > to)
                return false;

            for (var i = from; i <= to; i++)
            {
                var wordsToPrint = numbersWords.Keys.Where(key => key != 0).Where(key => (i%key == 0)).Aggregate(String.Empty, (current, key) => current + numbersWords[key]);
                Console.WriteLine("{0}{1}", i, wordsToPrint);
            }
            return true;
        }
    }
}
