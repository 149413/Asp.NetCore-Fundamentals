using Day_05_Demo.Sealed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_05_Demo.Partial
{
    // Developer 02
    internal partial class Employee : Parent
    {
        public string? Address { get; set; }

        public partial int DoSomeCode(int X)
        {
            throw new NotImplementedException();
        }
    }
}
