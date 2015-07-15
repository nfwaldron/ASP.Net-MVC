using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    // In this particular instance, the Calculator class functions as a View Model. We are just using the class
    // to store results and to return the values to the controller, which will pass the information back to the view
    public class CalculatorForm
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }
    }
}