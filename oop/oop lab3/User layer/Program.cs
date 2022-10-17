using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_layer
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu app = new Menu(@"C:\lab1\db.xml", "xml");
            app.AddStudent("Dmytro", "Petrenko", "Yes", "BD45678912", "BN78956412", 4);
            app.AddStudent("Andriy", "Petrow", "No", "VV78956320", "BH78923100", 4);
            app.AddStudent("Petro", "Ivanov", "No", "YR45698700", "BD45623100", 4);

            app.addInformationToFile();

            app.printInformation();

            app.AddStudent("Ivan", "Sydorenko", "No", "YR45698700", "BD45623100", 4);
            app.addInformationToFile();
            app.Divider();
            app.printInformation();

            app.Divider();
            app.outputFoundStudents();
        }
    }
}
