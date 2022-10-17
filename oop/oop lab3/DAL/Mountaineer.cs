using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mountaineer : Human
    {
        public Mountaineer() : base() { }
        public Mountaineer(string fname, string lname, string passport)
            : base(fname, lname, passport) { }
    }
}
