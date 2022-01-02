using System;

namespace MonteCarloIntegration22032021
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Initialise */
            int N, i;
            double a, b, func = 0.0, answer, r;

            /* Parameters */
            a = 0;
            b = Math.PI; //more accurate to not include lower bound for inf
            N = 100000000;

            /* Method */
            Random ran = new Random();

            for (i = 0;i < N;i++)
            {
                r = (b - a) * ran.NextDouble() + a;
                func +=  Math.Sin(r);
            }
            
            answer = (b - a) * func * (1.0 / N);
            Console.WriteLine("Answer: {0:0.0000000000}", answer);
            Console.WriteLine("Error:  {0:0.0000000000}%", 100*Math.Abs(answer - 2)/ 2);
        }
    }
}
