using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculatorAzure.Models
{
    internal class Operation
    {
        private string num1;
        private string num2;
        private string operation1;

        public string Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public string Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public string Operation1
        {
            get { return operation1; }
            set { operation1 = value; }
        }
    }
}
