using System;


namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        //recursive 
        public static int FibR(int N)
        {
            if (N > 1)
                return Fib(N - 1) + Fib(N - 2);
            else if (N == 1)
                return 1;
            else
                return 0;
        }
        //nonrecursive
        public static int Fib(int N)
        {
            int[] Fibarr = new int[31];
            Fibarr[0] = 0; Fibarr[1] = 1;
            for(int i=2; i < N+1; i++)
            {
                Fibarr[i] = Fibarr[i - 1] + Fibarr[i - 2];
            }           
                return Fibarr[N];
        }
        public static void FibTest()
        {
            for(int i=0; i < 20; i++)
            {
                Console.WriteLine(i+"\t"+ Fib(i));
                Console.WriteLine(i+"\t"+ FibR(i));
            }
        }
    }
}