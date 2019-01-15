﻿using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        char search = 'р';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == search)
            {
                hasMatch = true;

                int endIndex = jump;

                if (endIndex > text.Length)
                {
                    endIndex = text.Length;
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}