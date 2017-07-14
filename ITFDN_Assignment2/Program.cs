using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFDN_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1024";
            int answer = 0;
            int zeroPosition = 48;
            for(int i = 0; i<input.Length; i++)
            {
                answer = answer + (input[i] - zeroPosition) * (int)Math.Pow(10,(double)(input.Length-i-1));
            }

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
