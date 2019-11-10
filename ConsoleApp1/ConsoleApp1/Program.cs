using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstNonConsecutive(new int[] { 1, 2, 3, 4, 7, 5, 6 });
            Console.Read();
           
        }


        public static object FirstNonConsecutive(int[] arr)
        {
            int d = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (d != arr[i])
               {
                    Console.WriteLine(arr[i]);
                    return arr[i];
                }
                d++;
            }
            return null;
        }

        static int fib(int n)
        {
            if (n < 2 ) return n;
            return fib(n - 1) + fib(n - 2);
        }
        
        static int fibonacchiWithMemoization(int[] results, int n)
        {
            if (n == 0)
                return results[0];
            if(n == 1)
                return results[1];
            
            if (results[n] == 0)
            {
                results[n] = fibonacchiWithMemoization(results,n - 2) + fibonacchiWithMemoization(results,n - 1);
            }
            return results[n];
        }
        
        static int fib_n(int n)
        {
            int x = 1;
            int y = 0;
            for (int i = 0; i < n; i++)
            {
                x += y;
                y = x - y;
            }
            return y;
        }


    }
}
