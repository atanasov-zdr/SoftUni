﻿using System;
using System.Net;

namespace _01.URL_Decode
{
    class Program
    {
        static void Main()
        {
            string encodedUrl = Console.ReadLine();

            string decodedUrl = WebUtility.UrlDecode(encodedUrl);

            Console.WriteLine(decodedUrl);
        }
    }
}
