using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Resource
{
    class Program
    {
        static void Main(string[] args)
        {
            ////write a for loop to print 10 numbers
            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // Add ten numbers
            int total = 0;
            for(int j = 1; j <= 10; j++)
            {
                total = total + j;
                Console.WriteLine(total);
            }
        }
    }
}
