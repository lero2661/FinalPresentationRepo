using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemoProject
{
    //added this new comment
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.shorten("hello", 2));
            Console.ReadLine();
        }

        public  int addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public  int subtraction(int num1, int num2)
        {
            if(num1 >= num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }
        }

        public int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public string concat(string s1, string s2)
        {
            return s2 + s1;
        }

        public string rotate(string s)
        {
            return s.Substring(1, s.Length - 1) + s.Substring(0, 1);
        }

        public string shorten(string s1, int shortenby)
        {
            if(shortenby < s1.Length)
            {
                return s1.Substring(0, s1.Length - shortenby);
            }
            else
            {
                return "uhoh";
            }
        }

        public bool andlogic(bool b1, bool b2)
        {
            return b1 && b2;
        }

        public bool orlogic(bool b1, bool b2)
        {
            return b1 || b2;
        }

        public bool notlogic(bool b1)
        {
            return !b1;
        }
    }
}
