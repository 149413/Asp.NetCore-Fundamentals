using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_05_Demo.Sealed
{
    internal sealed class ImmutableString
    {
        private readonly string value;

        public string Value
        {
            get { return value; }
        }
        public ImmutableString(string value)
        {
            this.value = value; 
        }
    }
}
