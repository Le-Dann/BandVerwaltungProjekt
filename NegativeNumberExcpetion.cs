using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wndNewBand
{
    class NegativeNumberExcpetion : Exception
    {
        public NegativeNumberExcpetion(string message) : base(message) { }
    }
}
