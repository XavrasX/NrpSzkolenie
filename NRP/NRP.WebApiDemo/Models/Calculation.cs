using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NRP.WebApiDemo.Models
{
    public class Calculation
    {
        public Calculation(decimal left, Operation operation, decimal right)
        {
            LeftOperand = left;
            RightOperand = right;
            Operation = operation;
            Result = Calculate();
        }
        public decimal LeftOperand { get; set; }
        public decimal RightOperand { get; set; }
        public Operation Operation { get; set; }
        public decimal Result { get; set; }

        private decimal Calculate()
        {
            checked
            {
                switch (Operation)
                {
                    case Operation.Add:
                        return LeftOperand + RightOperand;
                    case Operation.Sub:
                        return LeftOperand - RightOperand;
                    case Operation.Mul:
                        return LeftOperand * RightOperand;
                    case Operation.Div:
                        return LeftOperand / RightOperand;
                    default:
                        throw new InvalidOperationException($"Operation {Operation} is not supported.");
                }
            }
        }
    }
}