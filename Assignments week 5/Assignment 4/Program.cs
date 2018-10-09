using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new array for max 20 nr
            int[] values = new int[20];

            int currNumber = 0;
            int position = 0;

            //Repeat "enter nr" till "0" has been put. 
            do
            {
                Console.Write("Enter a number (0=stop): ");
                currNumber = int.Parse(Console.ReadLine());

                //All nrs < 20 will be calculated towards occurences
                if (position < 20)
                {
                    values[position] = currNumber;

                    position++;
                }
            } while (currNumber != 0);

            //Resize array so it won't count extra 0's with searchvalue
            Array.Resize(ref values, position);

            //Read searchvalue
            Console.Write("Enter a searchvalue: ");
            int searchValue = int.Parse(Console.ReadLine());

            //Read/calc amount of occurences of searchvalue
            int occurrences = 0;
            foreach (int value in values)
            {
                if (value == searchValue)
                {
                    occurrences++;
                }
            }

            //Display occurences
            Console.WriteLine("Number of occurrences of searchvalue ({0}) is: {1}", searchValue, occurrences);
        }
    }
}
