using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    public class BusinessClass
    {
        private DataClass dataInstance = new DataClass();

        public void SaveToFile(string calculationString)
        {
            dataInstance.SaveToFile(calculationString);
        }








        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            dataInstance.SaveToFile($"{num1} + {num2} = {result}");
            return result;
        }

        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            dataInstance.SaveToFile($"{num1} - {num2} = {result}");
            return result;
        }

        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            dataInstance.SaveToFile($"{num1} * {num2} = {result}");
            return result;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
                throw new ArgumentException("Division by zero is not allowed.");
            double result = num1 / num2;
            dataInstance.SaveToFile($"{num1} / {num2} = {result}");
            return result;
        }
    }
}
