using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.DemoApp
{
    class DataInput
    {
        public int _valueA, _valueB;

        public void PromptUser()
        {
            Console.WriteLine("Enter 2 Numbers  ");
            _valueA = Convert.ToInt32(Console.ReadLine());
            _valueB = Convert.ToInt32(Console.ReadLine());
        }
    }

    class ArithmeticOperations : DataInput
    {
        public void CalculateSum()
        {
            int result = _valueA + _valueB;
            Console.WriteLine("Sum is  " + result);
        }

        public void CalculateDifference()
        {
            int result = _valueA - _valueB;
            Console.WriteLine("Sub is  " + result);
        }

        public void CalculateProduct()
        {
            int result = _valueA * _valueB;
            Console.WriteLine("Mult is  " + result);
        }
    }

    internal class CalculatorDemo
    {
        static void Main()
        {
            ArithmeticOperations calc = new ArithmeticOperations();
            calc.PromptUser();
            calc.CalculateSum();
            calc.CalculateDifference();
            calc.CalculateProduct();
        }
    }
}
