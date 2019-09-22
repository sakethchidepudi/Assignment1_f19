using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);
            Console.WriteLine();

            int n2 = 5;
            printSeries(n2);
            Console.WriteLine();

            int n3 = 5;
            printTriangle(n3);
            Console.WriteLine();

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);

            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                if (x > y)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    for (int num = x; num <= y; num++)
                    {
                        int SelfDividing = 1;
                        for (int temp = num; temp > 0; temp /= 10)
                        {
                            int dig = temp % 10;
                            if (dig == 0 || num % dig != 0)
                            {
                                SelfDividing = 0;
                                break;
                            }
                        }
                        if (SelfDividing == 1)
                        {
                            Console.Write("{0},",num);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            try
            {
                int print_count = 0;
                int start_count = 1;
                do
                {
                    for (int i = 0; i < start_count; i++)
                    {
                        Console.Write(start_count);
                        print_count += 1;
                        if (print_count == n)
                        {
                            break;
                        }
                    }
                    start_count += 1;
                } while (print_count < n);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                for (int i = n; i >= 1; i--)
                {
                    for (int k = 0; k < n - i; k++)
                        Console.Write(" ");
                    for (int j = i; j <= (2 * i) - 1; j++)
                        Console.Write("*");
                    for (int j = 0; j < i - 1; j++)
                        Console.Write("*");
                    Console.WriteLine(" \n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}
