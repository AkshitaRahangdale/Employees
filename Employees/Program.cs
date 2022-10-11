using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Static e1 = new Static("emp1", 23000);
            Static e2 = new Static("emp2", 234000);
            Static e3 = new Static("emp3", 235000);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(Static.TotalCount());
        }
    }
}
