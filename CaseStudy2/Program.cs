using System;

namespace CaseStudy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var inputStr = new string[] { "Robot", "step", "step", "getPos", "getDir", "step", "step", "step", "getPos", "getDir" };
            
            var array = new int?[,] { {6,3 }, {2,null},{ 2,null},{ null,null},{null,null},{2,null},{1,null},{4,null},{null,null}, {null,null} };
            var result= Case2.Run(inputStr, array);
       
        }
    }
}
