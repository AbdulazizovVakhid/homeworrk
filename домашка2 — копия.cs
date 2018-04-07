using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var s = Console.ReadLine();
                Console.WriteLine(Parse(s));
                Console.WriteLine(difParse(s));
            }
        }
        static int difParse (string s)
        {
            int index = 0;
            int num = Num(s, ref index);
            while (index < s.Length)
            {
                if (s[index] == '+')
                {
                    index++;
                    int b = Num(s, ref index);
                    num += b;
                }
                else if (s[index] == '*')
                {
                    index++;
                    int b = Num(s, ref index);
                    num *= b;
                }
                else if (s[index]== '/')
                {
                    index / ;
                    int b = Num(s, ref index);
                    num /= b;
                }
            }

            return num;
        }
        static int Parse(string s)
        {
            int index = 0;
            int num = Num(s, ref index);
            while (index < s.Length)
            {
                if (s[index] == '+')
                {
                    index++;
                    int b = Num(s, ref index);
                    num += b;
                }
                else if (s[index] == '-')
                {
                    index++;
                    int b = Num(s, ref index);
                    num -= b;
                }
                else
                {
                    Console.WriteLine("Error");
                    return 0;
                }
            }

            return num;
        }

        static int Num(string s, ref int i)
        {
            string buff = "0";
            for (; i < s.Length && char.IsDigit(s[i]); i++)
            {
                buff += s[i];
            }

            return int.Parse(buff);//01
        }
    }
}

