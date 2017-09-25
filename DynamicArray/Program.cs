using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            CCArray<int> ccArray = new CCArray<int>();
            ccArray.Add(2);
            ccArray.Add(3);
            Console.WriteLine(ccArray.ToString());
            Console.WriteLine(ccArray.Get(1));
            Console.ReadKey();
        }
    }
}
