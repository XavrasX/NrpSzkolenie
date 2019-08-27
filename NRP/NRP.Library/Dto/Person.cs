using NRP.Library.Common;
using System;

namespace NRP.Library.Dto
{
    internal class Person
    {
        // Id has to be positive value greater than 0
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                ValidateIsPositiveValue(value);

                _id = value;
            }
        }

        protected static void ValidateIsPositiveValue(int value)
        {
            if (value < 1) throw new InvalidOperationException(Errors.ValueHasBePositive);
        }

        public string AutoPropertyExample { get; set; }
    }
}
