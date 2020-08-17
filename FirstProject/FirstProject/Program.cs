using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static int Add(int n, int m)
        {
            return n + m;
        }
        static void Main(string[] args)
        {
          
            Console.WriteLine("This is the first app that demonstrates ");
            Console.WriteLine("Hello Git!");

            Console.WriteLine("78 + 13 = " + Add(78,13));

            Console.ReadLine();
            
        }
    }
}
