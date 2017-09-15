using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode557
{
    public class Solution
    {
        public static string ReverseWords(string s)
        {
            string unS;
            int k = -1;
            int NewIndex;
            char [] str = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                int SpaceInd = s.IndexOf(" ", i);

                if (SpaceInd < 0)
                {
                    NewIndex = s.Length - i + s.LastIndexOf(" ");
                }
                else
                {
                    NewIndex = SpaceInd + k - i;
                };
        
                if (i == SpaceInd)
                {
                    NewIndex = i;
                    k = i;
                }
         
                s.CopyTo(i, str, NewIndex, 1);
                
            };

            unS = String.Concat<char>(str);
         
            return (unS);
        }
    }
       
    class Program
    {
         static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = LeetCode557.Solution.ReverseWords(s);
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
