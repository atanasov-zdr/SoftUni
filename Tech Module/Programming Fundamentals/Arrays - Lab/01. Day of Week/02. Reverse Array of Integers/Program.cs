﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
