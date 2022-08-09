using CaseStudy1;
using System;

namespace CaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var r = new int[] { 37, 26, 14, 8, 1 };
            var response = Case1.GetProfit(r);
            Console.WriteLine(response);
        }

    }
}
