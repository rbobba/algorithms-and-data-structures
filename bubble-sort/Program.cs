﻿using System;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] {5,2,3,1};
            //var input = new int[] {5,3,4,1};
            //var input = new int[] {5,1,1,2,0,0};
            var output = Sort(input);
            foreach(int val in output)
            {
                Console.WriteLine(val);
            }
        }

        private static int[] Sort(int[] input)
        {
            if(input.Length <= 1)
                return input;
            int temp;
            for(int i = 0; i < input.Length-1; i++)
            {
                for(int j = i+1; j < input.Length; j++)
                {
                    if(input[i] > input[j])
                    {
                        temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
    }
}
