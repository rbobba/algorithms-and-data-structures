using System;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = new int[] {5,3,8,4,1,2};
            var input = new int[] {14,33,27,10,35};
            var output = RecusrsiveInsertionSort(input, 0);
            //var output = IterativeInsertionSort(input, input.Length);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] RecusrsiveInsertionSort(int[] input, int n)
        {
            if(n == input.Length-1 || input.Length <= 1)
            {
                return input;
            }
            for(int i = n; i >= 0; i--)
            {
                if(input[i] > input[i+1])
                {
                    int temp = input[i];
                    input[i] = input[i+1];
                    input[i+1] = temp;
                }
            }
            return RecusrsiveInsertionSort(input, n+1);
        }

        private static int[] IterativeInsertionSort(int[] input, int n)
        {
            if(input.Length <= 1)
                return input;
            for(int i = 1; i < n; i++)
            { 
                for(int j = i; j > 0; j--)
                {
                    if(input[j] < input[j-1])
                    {
                        int temp = input[j];
                        input[j] = input[j-1];
                        input[j-1] = temp;
                    }
                }
            }
            return input;
        }
    }
}
