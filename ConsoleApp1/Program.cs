using System;

namespace HomeWork
{
    class Program
    {
        static double Task1 (double a, double b)
        {
            return Math.Pow(a, b);
        }

        static void Task2 ()
        {
            int i;
            double a;
            
            a = Convert.ToDouble(Console.ReadLine());
            for (i = 0; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int Task3()
        {
            double a;
            double b = 0;
            int count = 0; 

            a = Convert.ToDouble(Console.ReadLine());
            b = a * a;
            for (int i = 0; i < b-1; i++)
            {
                if (a > 0)
                {
                    count++;
                } 
                else if (a < 0)
                {
                    a = Math.Abs(a);
                    count++;
                }
            }

            return count;
        }
        
        static int Task4()
        {
            int a;
            int devider = 0;

            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    devider = i;
                }
            }

            return devider;
        }
        
        static double Task5()
        {
            double sum = 0;
            double a, b;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                for (double i = a + 1; i > a && i < b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum = sum + i;
                    }
                }
            }
            else if (b < a)
            {
                for (double i = b + 1; i > b && i < a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum = sum + i;
                    }
                }
            }

            return sum;
        }

        static int fib(int n)
        {
            return n > 1 ? fib(n - 1) + fib(n - 2) : n;
        }

        static void Main()
        {
            //Console.WriteLine(Task1());
            //Task2();
            //Console.WriteLine(Task3());
            //Console.WriteLine(Task4());
            //Console.WriteLine(Task5());
            Console.WriteLine(fib(10));
        }
    }
}