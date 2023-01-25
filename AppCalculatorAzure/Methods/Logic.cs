using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCalculatorAzure.Models;

namespace AppCalculatorAzure.Methods
{
    internal class Logic
    {
        //private double result;
        private Result result;

        public Logic()
        {
            result = new Result();
        }

        public Result MultipleOperations(Operation operations)
        {
            switch (operations.Operation1)
            {
                case "add":
                    return Addition(operations.Num1,operations.Num2);
                case "subtract":
                    return Subtraction(operations.Num1, operations.Num2);
                case "multiply":
                    return Multiplication(operations.Num1, operations.Num2);
                case "division":
                    return Division(operations.Num1, operations.Num2);
                case "modulo":
                    return Modulo(operations.Num1, operations.Num2);
            }
            
            result.Error = "Invalid operation.";
            return result;
        }

        public Result Addition(string a, string b)
        {
            decimal c;
            decimal d;
            try 
            {
                c = Decimal.Parse(a);
                d = Decimal.Parse(b);
                result.Answer = c+d;
                return result;
            }
            catch(Exception e)
            {
                result.Error = e.Message;
                return result;
            }        
        }

        public Result Subtraction(string a, string b)
        {
            decimal c;
            decimal d;
            try
            {
                c = Decimal.Parse(a);
                d = Decimal.Parse(b);
                result.Answer = c - d;
                return result;
            }
            catch (Exception e)
            {
                result.Error = e.Message;
                return result;
            }
        }

        public Result Multiplication(string a, string b)
        {
            decimal c;
            decimal d;
            try
            {
                c = Decimal.Parse(a);
                d = Decimal.Parse(b);
                result.Answer = c * d;
                return result;
            }
            catch (Exception e)
            {
                result.Error = e.Message;
                return result;
            }
        }

        public Result Division(string a, string b)
        {
            decimal c;
            decimal d;
            try
            {
                c = Decimal.Parse(a);
                d = Decimal.Parse(b);
                result.Answer = c / d;
                return result;
            }
            catch (Exception e)
            {
                result.Error = e.Message;
                return result;
            }
        }

        public Result Modulo(string a, string b)
        {
            decimal c;
            decimal d;
            try
            {
                c = Decimal.Parse(a);
                d = Decimal.Parse(b);
                result.Answer = c % d;
                return result;
            }
            catch (Exception e)
            {
                result.Error = e.Message;
                return result;
            }
        }


    }
}
