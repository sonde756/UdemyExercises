﻿using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {

                   double a, raio, pi = 3.14159;

                raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                a = pi * raio * raio;


                    Console.WriteLine("A=" + a.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}


