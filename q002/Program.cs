using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*Author Moosa*/
        static void Main(string[] args)
        {
            int noofinputs = int.Parse(Console.ReadLine());
            
            for ( int  i = 0; i < noofinputs; i ++)
            {
                long input = long.Parse(Console.ReadLine());
                long firstterm = 0, secondterm = 2, thirdterm = 0;
                long sum = firstterm + secondterm;
                if (input < 2)
                {
                    sum = 0;                   
                }
                else
                {
                    for (long j = 0; thirdterm <= input; j++)
                    {
                        thirdterm = firstterm + (4 * secondterm);
                        firstterm = secondterm;
                        secondterm = thirdterm;
                        sum = sum + thirdterm;
                    }
                    if (sum >= input)
                    {
                        sum = sum - thirdterm;
                    }
                }
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
