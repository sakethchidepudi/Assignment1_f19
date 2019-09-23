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
                    Console.WriteLine("Invalid input");//If the first number is greater than second number,this part gets exeuted
                }
                else
                {
                    for (int num = x; num <= y; num++)//This loop runs from the first number through the last number of series
                    {
                        int SelfDividing = 1;
                        for (int temp = num; temp > 0; temp /= 10)//taking each number and dividing with 10 and saving it for next iteration
                        {
                            int dig = temp % 10;
                            if (dig == 0 || num % dig != 0)//getting the modulus and check if it can divide our number
                            {
                                SelfDividing = 0;
                                break;
                            }
                        }
                        if (SelfDividing == 1)// If the number is selfdividing it comes here and gets into the output series
                        {
                            Console.Write(" {0},",num);//Desired output 
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
                int print_count = 0;//initiating two variables in order to keep a count while getting the desired output
                int start_count = 1;
                do
                {
                    for (int i = 0; i < start_count; i++)  //loop for printing the series
                    {
                        Console.Write(start_count);
                        print_count += 1;
                        if (print_count == n)//If my variable reaches desired user input value it will break out.
                        {
                            break;
                        }
                    }
                    start_count += 1; //Incrementing my variable in first loop so that the number n gets displayed n times
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
                for (int i = n; i >= 1; i--)// To run the loop n times
                {
                    for (int k = 0; k < n - i; k++) //Loop for printing the spaces as rows get executed
                        Console.Write(" ");
                    for (int j = i; j <= (2 * i) - 1; j++)//Loop for first half of the triangle
                        Console.Write("*");
                    for (int j = 0; j < i - 1; j++)//Loop for the second half of the triangle
                        Console.Write("*");
                    Console.WriteLine(" \n");//For getting the stars in the next line after the loop
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
                int common  = 0;
                for (int a = 0; a < J.Length; a++)//Taking every element from the first array
                {
                    for (int b = 0; b < S.Length; b++)//Taking every element from the second array
                    {
                        if (J[a] == S[b]) //Comparing the elements from both the arrays
                        {
                            common += 1; //Getting the count of such matched values
                        }
                    }
                }
                return common; //Getting the outpiut
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
