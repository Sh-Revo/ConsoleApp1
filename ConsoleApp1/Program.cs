using System;

namespace HomeWork
{
    class Program
    {
        static double Task1 (double a, double b)
        {
            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            } 
            return result;
        }

/*        static double Task2 (double a)
        {
            int i;
            int count = 100;
            

            for (i = 0; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    count++;
                }
            }

            double[] mas = new double[count];

            for (i = 0; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    mas[i] = i;
                    count++;
                }
            }

            return mas[i];
        }*/

        static int Task3(double a)
        {
            double b = 0;
            int count = 0; 

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
        
        static int Task4(int a)
        {
            int divider = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    divider = i;
                }
            }

            return divider;
        }
        
        static double Task5(double a, double b)
        {
            double sum = 0;

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

        static int GRD(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        static int Task9(int number)
        {
            int result = 0;

            for (int i = 0; i < number; i++)
            {
                if(i % 2 == 1)
                {
                    result += 1;
                }
            }

            return result;
        }

        static int Task10(int number)
        {
            int result = 0;

            while (number != 0)
            {
                int current = number % 10;
                number /= 10;
                result *= 10;
                result += current;
            }

            return result;
        }

        static bool Task12(int a, int b)
        {
            int numb1, numb2;
            bool flag = false;
            int valueB;

            while (a != 0)
            {
                numb1 = a % 10;
                a /= 10;
                valueB = b;
                while (valueB != 0)
                {
                    numb2 = valueB % 10;
                    valueB /= 10;
                    if (numb1 == numb2)
                    {
                        flag = true;
                    }
                }
            }

            return flag;
        }

        static void Main()
        {
            //Console.WriteLine(Task1(2, 4));
            //Console.WriteLine(Task2(10));
            //Console.WriteLine(Task3(10));
            //Console.WriteLine(Task4());
            //Console.WriteLine(Task5());
            //Console.WriteLine(fib(10));
            //Console.WriteLine(GRD(36, 60));
            //Console.WriteLine(Task9(10));
            //Console.WriteLine(Task10(104));
            //Console.WriteLine(Task12(1216, 25483));
        }
    }
}