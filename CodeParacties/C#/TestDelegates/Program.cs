using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelegateLib;
namespace TestDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            MathAddition Addition = new MathAddition();
            MathsAddDelegate @delegate = Addition.MathAdd;
            Calculator calculator = new Calculator(@delegate);
            Console.WriteLine($"Addition of the Two Numbers are :{calculator.Add(10, 20)}"); 
        }
    }

    public class MathAddition
    {
        public int MathAdd(int aintNumber1 , int aintNumber2)
        {
            return aintNumber1 + aintNumber2;
        }
    }
}
