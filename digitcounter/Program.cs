using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitcounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] countArray = { 0,0,0,0,0,0,0,0,0,0 };

            Console.Write("Input data: ");
            string input = Console.ReadLine();

            string[] inputArray = input.Split(',');

            for (int i = 0; i < inputArray.Length; i++)
            {
                countArray[int.Parse(inputArray[i])]++;
            }

            for (int i = 0; i < countArray.Length; i++)
            {
                Console.Write("\n" + i + "\t" + countArray[i]);
            }

            Console.ReadLine();
        }
    }
}
