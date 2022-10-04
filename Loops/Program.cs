using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n2 < n1 && n1 > n3)
            {
                Console.WriteLine($"{n1} is greater");
            }
            else if (n1 < n2 && n2 > n3)
            {
                Console.WriteLine($"{n2} is greater");
            }
            else
            {
                Console.WriteLine($"{n3} is greater");
            }
        }
    }
}