using System;
using System.IO;

namespace Lab_1
{
    public class DBStudent : DBModel
    {
        public DBStudent(string path) : base(path) { }

        public string addToTheDB(Student a)
        {
            if (this.IsInTheDB(a))
            {
                return "Student is already in the db!";
            }

            if (!File.Exists(path))
            {
                using (StreamWriter s = File.CreateText(path))
                {
                    s.WriteLine("Student {0}{1}", a.FirstName, a.LastName);
                    s.WriteLine("{\"" + "FirstName\": " + "\"" + a.FirstName + "\",");
                    s.WriteLine("\"LastName\": " + "\"" + a.LastName + "\",");
                    s.WriteLine("\"PassportID\": " + "\"" + a.PassportID + "\",");
                    s.WriteLine("\"StudentID\": " + "\"" + a.Card_id + "\",");
                    s.WriteLine("\"Scholarship\": " + "\"" + a.Scholar + "\",");
                    s.WriteLine("\"Year\": " + "\"" + a.Year + "\"};");

                    this.list[this.getFilledPositions()] = a;

                    return "Student added";
                }
            }
            else
            {
                using (StreamWriter s = File.AppendText(path))
                {
                    s.WriteLine("Student {0}{1}", a.FirstName, a.LastName);
                    s.WriteLine("{\"" + "FirstName\": " + "\"" + a.FirstName + "\",");
                    s.WriteLine("\"LastName\": " + "\"" + a.LastName + "\",");
                    s.WriteLine("\"PassportID\": " + "\"" + a.PassportID + "\",");
                    s.WriteLine("\"StudentID\": " + "\"" + a.Card_id + "\",");
                    s.WriteLine("\"Scholarship\": " + "\"" + a.Scholar + "\",");
                    s.WriteLine("\"Year\": " + "\"" + a.Year + "\"};");

                    this.list[this.getFilledPositions()] = a;

                    return "Student added";
                }
            }
        }

        //Method for filling the list 
        public override void getDB()
        {
            if (File.Exists(path))
            {
                using (StreamReader r = File.OpenText(path))
                {
                    string s;
                    while ((s = r.ReadLine()) != null)
                    {
                        //subs - the array with 2 elements - characteristic and its name
                        //for example, subs[0] - firstName, sub[1] - Mykola
                        string[] subs = s.Split(' ');

                        //In this array would be characteristics for the student from the db
                        string[] characteristics = new string[6];

                        //check whether the new line is for the new student 
                        if (subs[0].Equals("Student"))
                        {
                            //fill characteristics array
                            for (int i = 0; i < 6; i++)
                            {
                                s = r.ReadLine();
                                subs = s.Split(' ');
                                subs[1] = subs[1].Replace(",", "").Replace(";", "").Replace("\"", "").Replace("{", "").Replace("}", "");
                                characteristics[i] = subs[1];
                            }

                            //add new student to the list
                            list[getFilledPositions()] = new Student(characteristics[0], characteristics[1], characteristics[3], Convert.ToByte(characteristics[5]), characteristics[4], characteristics[2]);
                        }
                    }
                }
            }
        }

        //Function for searching 4-course students with no scholarship
        public Student taskVariant14()
        {
            if (this.getFilledPositions() == 0)
            {
                this.getDB();
            }

            int i = 0;
            while (list[i] != null)
            {
                if (((Student)list[i]).Year == 4 && ((Student)list[i]).Scholar.Equals("No"))
                {
                    return (Student)list[i];
                }
                ++i;
            }
            return null;
        }

        public Student studentIDSearch(string id)
        {
            if (this.getFilledPositions() == 0)
            {
                this.getDB();
            }

            int i = 0;
            while (list[i] != null)
            {
                if (((Student)list[i]).Card_id.Equals(id))
                {
                    return (Student)list[i];
                }
                ++i;
            }
            return null;
        }
    }
}