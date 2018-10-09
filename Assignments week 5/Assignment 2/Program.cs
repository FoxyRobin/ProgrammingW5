using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new array for random values
            int[] randomValues = new int[20];
            Random rnd = new Random();

            //Create random numbers
            for (int i = 0; i < 20; i++)
            {
                int value = rnd.Next(150);

                randomValues[i] = value;
            }

            //Display created numbers
            for (int i = 0; i < 20; i++)
            {
                int value = randomValues[i];
                Console.WriteLine("Element {0} = {1}", i, value);
            }


            //
            int min = 150;
            foreach (int value in randomValues)
            {
                if (value < min)
                {
                    min = value;
                }
            }

            //See how many times the smallest number occures 
            int nrOcc = 0;
            foreach (int value in randomValues)
            {
                if (value == min)
                {
                    nrOcc++;
                }
            }

            //Display smallest nr + nr of occurence
            Console.WriteLine("smallest number = {0}", min);
            Console.WriteLine("number of occurence = {0}", nrOcc);
        }
    }
}
