﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceProgram
{
    /// <summary>
    /// Design Principle 
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Defines Entry point of application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome to Cab Invoice Program***********");
            //Creating Object
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator((RideType.NORMAL));
            //Calculate Fare double
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare: {fare}");

            Console.ReadLine();

        }
    }
}