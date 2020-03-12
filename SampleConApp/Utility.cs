﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Prompt....
namespace SampleConApp
{
    static class Utility
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }


        public static int GetNumber(string question)
        {
            return int.Parse(GetString(question));
        }

        public static double GetDouble(string question)
        {
            return double.Parse(GetString(question));
        }

        public static void ClearScreen()
        {
            Console.WriteLine("Press any key to Clear");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
