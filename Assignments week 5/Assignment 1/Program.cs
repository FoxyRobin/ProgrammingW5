using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new array for random values
            int[] randomValues = new int[20];
            Random rnd = new Random();
            int total = 0;

            //Create random values
            for (int i = 0; i < 20; i++)
            {
                int value = rnd.Next(200);
                randomValues[i] = value;

            }

            //Display random values
            for (int i = 0; i < 20; i++)
            {
                int value = randomValues[i];
                Console.WriteLine("Element {0} is {1}", i, value);
                
                //calc total of all given values
                total = total + value;
            }

            //Calc average of all given values
            double average = (double)total / randomValues.Length;
            Console.WriteLine("The average is: {0:0.00}", average);

            //Calc difference between average & element
            for (int i = 0; i < 20; i++)
            {
                int value = randomValues[i];
                double diff = Math.Abs(average - value);
                
                //Display difference
                Console.WriteLine("Difference between average and element {0} is {1:0.00}", i, diff);
            }

            Console.ReadKey();

        }
    }
}
