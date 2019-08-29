using NRP.WebApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NRP.WebApiDemo.Controllers
{
    public class CalculatorController : ApiController
    {
        [HttpGet]
        public Calculation Add(decimal left, decimal right)
        {
            System.Threading.Thread.Sleep(3000); // symulacja lagów
            return new Calculation(left, Operation.Add, right);
        }
        [HttpGet]
        public Calculation Sub(decimal left, decimal right)
        {
            System.Threading.Thread.Sleep(3000); // symulacja lagów
            return new Calculation(left, Operation.Add, right);
        }
        [HttpGet]
        public Calculation Mul(decimal left, decimal right)
        {
            System.Threading.Thread.Sleep(3000); // symulacja lagów
            return new Calculation(left, Operation.Mul, right);
        }
        [HttpGet]
        public Calculation Div(decimal left, decimal right)
        {
            System.Threading.Thread.Sleep(3000); // symulacja lagów
            return new Calculation(left, Operation.Div, right);
        }
    }
}
