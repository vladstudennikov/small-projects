using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL;

namespace User_layer
{
    class Menu
    {
        private BusinessLogic menu;

        public Menu(string file,
                    string format)
        {
            menu = new BusinessLogic(file, format);
        }

        public void AddStudent(string fname, string lname, string scholar, string pas, string id, int year)
        {
            menu.addStudent(fname, lname, scholar, pas, id, year);
        }

        public void printInformation()
        {
            foreach (object el in menu.List.StudentList)
            {
                Console.WriteLine(el.ToString());
            }
        }

        public void Divider()
        {
            Console.WriteLine();
        }

        public void addInformationToFile()
        {
            menu.List = menu.StudentToStudents(menu.l);
        }

        public void outputFoundStudents()
        {
            foreach (object l in menu.Find())
            {
                Console.WriteLine(l.ToString());
            }
        }
    }
}
