using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NRP.Library.Tests.ConoleAppSubstitute
{
    [TestClass]
    public class ProgrammingCases
    {
        [TestMethod]
        public void SignChanged_Demo()
        {
            var i = int.MaxValue;

            Console.WriteLine(i);
            try
            {
                checked
                {
                    Console.WriteLine(++i);
                }
            }
            catch (OverflowException)
            {

                Console.WriteLine("Przekrecenie licznika na znak ujemny");
            }
        }
    }
}
