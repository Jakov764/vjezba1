﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more.";
            string s2 = "Italija je prvak svjeta!";
            string s3 = s1.Substring(0, 8) + s2.Substring(8, s2.Length - 8);
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
