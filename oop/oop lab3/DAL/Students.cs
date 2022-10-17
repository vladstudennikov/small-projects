using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Students
    {
        private List<Student> listOfStudents;

        public Students(List<Student> arr)
        {
            listOfStudents = arr;
        }

        public Students() { }

        public List<Student> StudentList
        {
            get => listOfStudents;
            set
            {
                listOfStudents = value;
            }
        }
    }
}
