using System.IO;

namespace Lab_1
{
    public class DBMountaineer : DBModel
    {
        public DBMountaineer(string path) : base(path) { }

        public string addToTheDB(Mountaineer a)
        {
            if (this.IsInTheDB(a))
            {
                return "Mountaineer is already in the db!";
            }

            if (!File.Exists(path))
            {
                using (StreamWriter s = File.CreateText(path))
                {
                    s.WriteLine("Mountaineer {0}{1}", a.FirstName, a.LastName);
                    s.WriteLine("{\"" + "FirstName\": " + "\"" + a.FirstName + "\",");
                    s.WriteLine("\"LastName\": " + "\"" + a.LastName + "\",");
                    s.WriteLine("\"PassportID\": " + "\"" + a.PassportID + "\"};");

                    this.list[this.getFilledPositions()] = a;

                    return "Mountaineer added!";
                }
            }
            else
            {
                using (StreamWriter s = File.AppendText(path))
                {
                    s.WriteLine("Mountaineer {0}{1}", a.FirstName, a.LastName);
                    s.WriteLine("{\"" + "FirstName\": " + "\"" + a.FirstName + "\",");
                    s.WriteLine("\"LastName\": " + "\"" + a.LastName + "\",");
                    s.WriteLine("\"PassportID\": " + "\"" + a.PassportID + "\"};");

                    this.list[this.getFilledPositions()] = a;

                    return "Mountaineer added!";
                }
            }
        }

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
                        if (subs[0].Equals("Mountaineer"))
                        {
                            //fill characteristics array
                            for (int i = 0; i < 3; i++)
                            {
                                s = r.ReadLine();
                                subs = s.Split(' ');
                                subs[1] = subs[1].Replace(",", "").Replace(";", "").Replace("\"", "").Replace("{", "").Replace("}", "");
                                characteristics[i] = subs[1];
                            }

                            //add new student to the list
                            list[getFilledPositions()] = new Mountaineer(characteristics[0], characteristics[1], characteristics[2]);
                        }
                    }
                }
            }
        }
    }
}
