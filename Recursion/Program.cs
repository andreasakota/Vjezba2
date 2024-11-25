using System.Xml.XPath;

using System;

using System.Diagnostics;

namespace Recursions
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
        static int FactorialIter(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int FibonacciIter(int n)
        {
            if (n <= 1) return n;

            int a = 0, b = 1, temp;

            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }

       
        static void Main(string[] args)
        {
            int n = 20; // Povećajte vrijednost n za duže vrijeme izvršavanja

            Stopwatch stopwatch = new Stopwatch();

            // Rekurzivni faktorijel
            stopwatch.Start();
            int result = Factorial(n);
            stopwatch.Stop();
            Console.WriteLine("Rekurzivni faktorijel od {0} = {1}, vrijeme trajanja: {2} ms ({3} ticks)", n, result, stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);

            // Iterativni faktorijel
            stopwatch.Restart();
            result = FactorialIter(n);
            stopwatch.Stop();
            Console.WriteLine("Iterativni faktorijel od {0} = {1}, vrijeme trajanja: {2} ms ({3} ticks)", n, result, stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);

            n = 30; // Veća vrijednost n za Fibonacci

            // Rekurzivni Fibonacci
            stopwatch.Restart();
            result = Fibonacci(n);
            stopwatch.Stop();
            Console.WriteLine("Rekurzivni Fibonacci od {0} = {1}, vrijeme trajanja: {2} ms ({3} ticks)", n, result, stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);

            // Iterativni Fibonacci
            stopwatch.Restart();
            result = FibonacciIter(n);
            stopwatch.Stop();
            Console.WriteLine("Iterativni Fibonacci od {0} = {1}, vrijeme trajanja: {2} ms ({3} ticks)", n, result, stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
        }

    }
}

