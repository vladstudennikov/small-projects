using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RateException : Exception
    {
        public RateException() : base() { }
        public RateException(string msg) : base(msg) { }
    }
}
