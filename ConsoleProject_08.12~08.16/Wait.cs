using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16
{
    static public class Waits
    {
        public static void Wait(int second)
        {
            Thread.Sleep(second * 1000);
        }
    }
}
