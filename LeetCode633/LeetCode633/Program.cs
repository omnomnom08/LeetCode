using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode633
{
    public class Solution
    {
        public static bool JudgeSquareSum(int c)
          {
            int a = 0;
            double h = 1;
            int intb = 0;
            double b = 0;

            while (a * a <= c / 2) 
            {
                b = Math.Sqrt((double)(c - a * a));
                intb = (int)(b);
                h = b - intb;
                if (h == 0)
                {
                    return true;
                }
                a++;
            };
            
            return false;
            
        }
        static void Main(string[] args) 
        {
            int c = Convert.ToInt32(Console.ReadLine());

            if (LeetCode633.Solution.JudgeSquareSum(c) == true) 
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey(); 
        }
    }
}
