using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemoProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.addition(1, 2));
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
    }
}
