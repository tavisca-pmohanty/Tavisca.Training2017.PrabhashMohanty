﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            input.InputString();
            StringReversal reversal = new StringReversal();
            reversal.ReverseOfString(input);
            Console.ReadLine();
        }
    }
}