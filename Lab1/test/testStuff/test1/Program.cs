using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;
            System.Console.WriteLine("Enter your age");
            userAge = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Your age Is");
            System.Console.WriteLine(userAge);

            System.Console.ReadKey();
        }
    }
}
