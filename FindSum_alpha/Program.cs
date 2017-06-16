using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSum_alpha
{

    class Program
    {
        string space = " ";

        static void Main(string[] args)
        {
            Program app = new Program();
            app.matchSum(8, 4, -1, 4, 4, 9);
            Console.ReadLine();
        }

        private void matchSum(int sumReq, int size, int b, int c, int d, int f)
        {
            int[] numbers = new int[size];

            numbers[0] = b;
            numbers[1] = c;
            numbers[2] = d;
            numbers[3] = f;

            foreach (int testNum in numbers)
            {
                int comp = sumReq - testNum;                

                if (numbers.Contains(comp))
                {
                    Console.WriteLine("Found:  " + testNum.ToString() + space + "+" + space + comp.ToString() + space + "=" + space + sumReq);
                }

            }

      
        }
    }
}
