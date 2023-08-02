using System;

namespace CodingChallenge
{
    public class Print1ToNWithoutLoop
    {
        static int[] arr;
        static int i = 0;
        public static void Start()
        {
            Console.WriteLine("Enter the number - ");
            int n = Convert.ToInt32(Console.ReadLine());
            var result = PrintNos(n);
            for (int j = 0; j < n; j++)
            {
                Console.Write(result[j] + " ");
            }

            //PrintReverseNos(n);

            var reverseNos = PrintReverseNos(n);
            foreach (var j in reverseNos)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }

        public static int[] PrintNos(int x)
        {
            //Console.WriteLine($"PrintNos - {x}");
            if(arr == null)
            {
                arr = new int[x];
            }

            if (x <= 0)
            {
                return arr;
            }
            arr[x-1] = x;
            
            return PrintNos(x - 1);
            
        }

        public static int[] PrintReverseNos(int x)
        {
            if (arr == null)
            {
                arr = new int[x];
            }

            if (x <= 0)
            {
                return arr;
            }
            arr[i] = x;
            i++;
            return PrintReverseNos(x - 1);

        }

        //public static void PrintReverseNos(int n)
        //{          
        //    if (n <= 0)
        //    {
        //        return;
        //    }
        //    Console.WriteLine(n);
        //    PrintReverseNos(n - 1);

        //}
    }

    public class BasicRecursionProblem
    {
        public static void Main(string[] args)
        {
            Print1ToNWithoutLoop.Start();
        }
    }
}