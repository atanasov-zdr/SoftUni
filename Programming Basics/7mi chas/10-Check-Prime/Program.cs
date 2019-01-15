﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var prime = true;

            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (n < 2) Console.WriteLine("Not Prime");
            else if (prime) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
            


        }
    }
}
