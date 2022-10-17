using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    public class BusinessLogic
    {
        private DataContext1<Students> _dataContext;
        Student tmp = new Student();
        public List<Student> l;

        public BusinessLogic(string path, string format)
        {
            _dataContext = new DataContext1<Students>(path);
            tmp = new Student();
            l = new List<Student>();
            if (format.ToLower().Equals("xml"))
            {
                _dataContext.DataProvider = new XMLDataProvider<Students>();
            }
            else if (format.ToLower().StartsWith("bi"))
            {
                _dataContext.DataProvider = new BinaryDataProvider<Students>();
            }
            else
            {
                _dataContext.DataProvider = new XMLDataProvider<Students>();
            }
        }

        public Students List
        {
            get
            {
                try
                {
                    Students arr = _dataContext.GetData();
                    return arr;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            set
            {
                try
                {
                    _dataContext.SetData(value);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void addStudent(string fname, string lname, string scholar, string pas, string id, int year)
        {
            this.tmp = new Student();
            tmp.FirstName = fname;
            tmp.LastName = lname;
            tmp.Scholar = scholar;
            tmp.Passport = pas;
            tmp.ID = id;
            tmp.Year = year;
            l.Add(tmp);
        }

        public List<Student> Find()
        {
            List<Student> l = new List<Student>();
            foreach (Student el in List.StudentList)
            {
                if (el.Year == 4 && el.Scholar.Equals("No"))
                {
                    l.Add(el);
                }
            }

            return l;
        }

        public Students StudentToStudents(List<Student> s)
        {
            return new Students(s);
        }
    }
}
