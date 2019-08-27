using System;
using NRP.Library.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NRP.Library.Tests.Dto
{
    [TestClass]
    public class PersonTests
    {
        private class FakePerson : Person
        {
            public new void ValidateIsPositiveValue(int value)
            {
                Person.ValidateIsPositiveValue(value);
            }
        }

        [TestMethod]
        public void Validate_0_ThrowsException()
        {
            var person = new FakePerson();

            var actual = Assert.ThrowsException<InvalidOperationException>(() => person.ValidateIsPositiveValue(0));

            Assert.AreEqual("Value has to be positive", actual.Message);
        }

        [TestMethod]
        public void Id_Set0_ThrowsException()
        {
            var person = new Person();

            var actual = Assert.ThrowsException<InvalidOperationException>(() => person.Id = 0);

            Assert.AreEqual("Value has to be positive", actual.Message);
        }

        [TestMethod]
        public void Id_SetMinus1_ThrowsException()
        {
            var person = new Person();

            var actual = Assert.ThrowsException<InvalidOperationException>(() => person.Id = -1);

            Assert.AreEqual("Value has to be positive", actual.Message);
        }
    }
}
