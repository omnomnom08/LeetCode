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
            char [] str = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                int NewIndex = s.IndexOf(" ", i) + k - i;
              //  Console.WriteLine("PROBEL");
              //  Console.WriteLine(s.IndexOf(" ", i));
                if (NewIndex<-1)
                {
                    NewIndex =  s.Length - i + s.LastIndexOf(" ");                  
                };
                if (i == s.IndexOf(" ", i))
                {
                    NewIndex = i;
                    k = i;
                }
             //   Console.WriteLine("NEWINDEX");
             //   Console.WriteLine(NewIndex);
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
