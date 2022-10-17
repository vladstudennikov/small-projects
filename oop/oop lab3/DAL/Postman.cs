using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Postman : Human
    {
        public Postman() : base() { }
        public Postman(string fname, string lname, string passport)
            : base(fname, lname, passport) { }
    }
}
