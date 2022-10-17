using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace ConsoleOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMenu m = new ConsoleMenu();

            Postman a = new Postman("Dmytro", "A", "HG45612378");
            Postman b = new Postman("Ivan", "B", "LJ46589720");
            Postman c = new Postman("Andriy", "C", "RT78541200");

            string path = @"C:\lab1\testPostman.txt";
            DBPostman db = new DBPostman(path);

            m.ExecuteAndOutput(db.addToTheDB(a));
            m.ExecuteAndOutput(db.addToTheDB(b));
            m.ExecuteAndOutput(db.addToTheDB(c));
            m.ExecuteAndOutput(db.lastNameSearch("C").FirstName);

            Student st1 = new Student("Ivan", "A", "FR78521406", 5, false, "TR74563211");
            Student st2 = new Student("Dmytro", "B", "FE11111406", 4, false, "VC45002236");
            Student st3 = new Student("Andriy", "C", "FY00114489", 4, true, "VC78502236");

            string path2 = @"C:\lab1\testStudent.txt";
            DBStudent dbS = new DBStudent(path2);

            m.ExecuteAndOutput(dbS.addToTheDB(st1));
            m.ExecuteAndOutput(dbS.addToTheDB(st2));
            m.ExecuteAndOutput(dbS.addToTheDB(st3));
            m.ExecuteAndOutput(dbS.taskVariant14().LastName);
        }
    }
}
