using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    internal class Program
    {
        //https://leetcode.com/problems/roman-to-integer/description/
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(RomanToInt(s));
            Console.ReadKey();
        }


        static int RomanToInt(string s) 
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    if (Val(s[i]) < Val(s[i + 1]))
                    {
                        result += Val(s[i + 1]) - Val(s[i]);
                        i++;
                    }
                    else result += Val(s[i]);
                }
                else result += Val(s[i]);
            }
            return result;
        }
        static int Val(char a)
        {
            if (a == 'I') return 1;
            if (a == 'V') return 5;
            if (a == 'X') return 10;
            if (a == 'L') return 50;
            if (a == 'C') return 100;
            if (a == 'D') return 500;
            if (a == 'M') return 1000;
            return -1;
        }
    }
}
