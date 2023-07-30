using System;
using System.Collections.Generic;

namespace CodingChallenge
{
    public class CountDigit
    {
        public void Starting()
        {
            Console.Write("Enter number of testcases you want - ");
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                Console.WriteLine("Enter the number - ");
                int n = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine($"Entered number is {n} ");
                int count = CountDigits(n);
                Console.WriteLine($"count of Number of digit of {n} that evenly divides are {count}");
            }
        }

        public int CountDigits(int n)
        {
            int countDigits = 0;
            int temp = n;
            while (temp != 0)
            {
                int digit = temp % 10;
                if (n % digit == 0)
                {
                    countDigits++;
                    //Console.WriteLine($"n is {n} and digit is {digit}");
                }
                temp = temp / 10;
                //Console.WriteLine($"temp is {temp}");
            }
            return countDigits;
        }
    }

    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int temp = x % 10;
                x = x / 10;
                if (rev > Int32.MaxValue / 10 || rev < Int32.MinValue / 10)
                {
                    return 0;
                }
                rev = rev * 10 + temp;

            }
            return rev;
        }
    }

    public class PalindromeNumber
    {
        public void palindrome()
        {
            Console.Write("Enter number of testcases you want - ");
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                Console.WriteLine("Enter the number - ");
                int n = Convert.ToInt32(Console.ReadLine());
                ReverseInteger reverseInteger = new ReverseInteger();
                int reverse = reverseInteger.Reverse(n);
                if (reverse == n)
                {
                    Console.WriteLine("Given number is Palindrome");
                }
                else
                {
                    Console.WriteLine("Given number is not a Palindrome");
                }
            }
        }
    }

    public class ArmstrongNumber
    {
        public void checkArmstrong()
        {
            Console.Write("Enter number of testcases you want - ");
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                Console.WriteLine("Enter the number - ");
                int n = Convert.ToInt32(Console.ReadLine());
                var noOfDigits = (int)Math.Floor(Math.Log10(n) + 1);  // count digits in an integer
                //Console.WriteLine(noOfDigits);
                int number = n;
                int result = 0;
                while (n != 0)
                {
                    int temp = n % 10;
                    result = result + (int)Math.Pow(temp, noOfDigits);
                    n /= 10;
                }
                if (result == number)
                {
                    Console.WriteLine("Given number is armstrong");
                }
                else
                {
                    Console.WriteLine("Given number is not armstrong");
                }
            }
        }
    }

    public class PrimeNumber
    {
        public static void isPrimeNumber()
        {
            Console.Write("Enter number of testcases you want - ");
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                Console.WriteLine("Enter the number - ");
                int n = Convert.ToInt32(Console.ReadLine());

                int count = 0;

                // Brute force approach - TC = O(n)
                //for (int j = 2; j < n; j++)
                //{
                //    if (n % j == 0)
                //    {
                //        count++;
                //        break;
                //    }
                //}

                // Better approach - TC = O(sqrt(n))
                for (int j = 2; j < Math.Sqrt(n); j++)
                {
                    if (n % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("Given number is Prime");
                }
                else
                {
                    Console.WriteLine("Given number is not Prime");
                }
            }
        }
    }

    public class PrintAllDivisor
    {
        public void Start()
        {
            Console.Write("Enter number of testcases you want - ");
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                Console.WriteLine("Enter the number for which you want to find all divisor - ");
                int n = Convert.ToInt32(Console.ReadLine());
                List<int> allDivisors = printDivisors(n);
                Console.WriteLine("All divisos of {0} are",n);
                foreach(var divisor in allDivisors)
                {
                    Console.WriteLine(divisor);
                }
            }
        }

        public static List<int> printDivisors(int n)
        {
            var divisor = new List<int>();

            //Brute Force - TC = O(n)
            //for (int i = 1; i <= n; i++)
            //{
            //    if(n%i==0)
            //    {
            //        divisor.Add(i);
            //    }
            //}

            //Better approach - TC = O(sqrt(n))
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if(n%i==0)
                {
                    divisor.Add(i);
                    if(i != n/i)
                    {
                        divisor.Add(n/i);
                    }
                }
            }

            return divisor;
        }
    }

    public class BasicMathsProblem
    {
        public static void Main(string[] args)
        {
            PrintAllDivisor printAllDivisor = new PrintAllDivisor();
            printAllDivisor.Start();

            //PrimeNumber.isPrimeNumber();

            ArmstrongNumber armstrongNumber = new ArmstrongNumber();
            //armstrongNumber.checkArmstrong();

            PalindromeNumber palindromeNumber = new PalindromeNumber();
            //palindromeNumber.palindrome();

            ReverseInteger reverseInteger = new ReverseInteger();
            //Console.WriteLine($"123 is reversed to {reverseInteger.Reverse(123)}");

            CountDigit countDigit = new CountDigit();
            //countDigit.Starting();
        }

    }
}

