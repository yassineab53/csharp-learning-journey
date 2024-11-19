using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.53D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.00}", value));

            Console.ReadLine();
        }
    }
}
