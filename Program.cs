﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_of_the_Week_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string monday = "Monday";

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

                
            foreach (string day in daysOfWeek)
            {

                Console.WriteLine(day);
            }
        }
    }
}
