﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var calories = 0.0;

            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese") calories += 500;
                else if (ingredient == "tomato sauce") calories += 150;
                else if (ingredient == "salami") calories += 600;
                else if (ingredient == "pepper") calories += 50;
            }

            Console.WriteLine("Total calories: {0}", calories);


        }
    }
}
