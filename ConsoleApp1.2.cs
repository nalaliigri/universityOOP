using System;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            N = Convert.ToDouble(Console.ReadLine());
            int check = Convert.ToInt32(N);
            if (N == check)
            {
                Console.WriteLine("Ви ввели число " + N);
            }
        }
    }
}
