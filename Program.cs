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
            // Numeric formatting
            /*double value = 1000D / 12.53D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.00}", value)); */

            //TryParse 
            Console.WriteLine("Enter a number : ");
            string numInput = Console.ReadLine();
            //int n = Convert.ToInt32(st);
            int num = 0;

            int.TryParse(numInput, out num);
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
