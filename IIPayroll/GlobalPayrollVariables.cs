//Name: Isaac Ingles
//Class: INFO 1200
//Section: X01
//Professor: Jensen
//Date: 9/22/2020
//Project #: Participation 6
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.Text;

namespace IIPayroll
{   
    /// <summary>
    ///  Static means you don't have to re-instantiate this every time you use it
    /// </summary>
    public static class GlobalPayrollVariables
    {
        // Create a variable that is readable and writable
        // To use, type GlobalPayrollVariables.<name>

        // for hours
        public static double Hours { get; set; }
        // For pay
        public static decimal Pay  { get; set; }


    }
}
