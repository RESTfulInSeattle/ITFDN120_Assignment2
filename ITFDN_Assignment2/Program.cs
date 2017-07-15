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
            //Set the ASCII position of 0
            int zeroPosition = 48;
            for(int i = 0; i<input.Length; i++)
            {
                //Use the character's ASCII position to determine the number it is and
                //use the position in the string to determine the power of 10
                answer = answer + (input[i] - zeroPosition) * (int)Math.Pow(10,(double)(input.Length-i-1));
            }

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
