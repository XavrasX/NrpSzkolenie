using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRP.Library
{
    public class WarningOmmittedExample
    {
#pragma warning disable CS603
        public object FakeWarningGeneratingCS603 { get; set; }
#pragma warning restore CS603
    }
}
