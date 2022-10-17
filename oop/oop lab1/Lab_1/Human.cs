using System.Text.RegularExpressions;

namespace Lab_1
{
    public class Human
    {
        private string _firstName;
        private string _lastName;
        private string _passportID;

        //next values are not stored in a database, for simplicity database contains only general information
        private int[] _studyingHours = new int[] { 0, 0, 0, 0, 0, 0 };
        private int _drawnPictures = 0;

        public Human(string firstName, string lastName, string passportID)
        {
            FirstName = firstName;
            LastName = lastName;
            PassportID = passportID;
        }

        public string FirstName
        {
            get => (_firstName.Equals("Invalid")) ? "Please, check the name" : _firstName;
            set
            {
                string pattern = @"^[A-Z]{1}[a-z]{0,15}$";
                _firstName = (Regex.IsMatch(value, pattern)) ? value : "Invalid";
            }
        }

        public string LastName
        {
            get => (_lastName.Equals("Invalid")) ? "Please, check the name" : _lastName;
            set
            {
                string pattern = @"^[A-Z]{1}[a-z]{0,15}$";
                _lastName = (Regex.IsMatch(value, pattern)) ? value : "Invalid";
            }
        }

        public string PassportID
        {
            get => (_passportID.Equals("Invalid")) ? "Please, check the passport ID" : _passportID;
            set
            {
                string pattern = @"^[A-Z]{2}[0-9]{8}$";
                _passportID = (Regex.IsMatch(value, pattern)) ? value : "Invalid";
            }
        }

        public string drawnPictures
        {
            get => "Drawn pictures: " + this._drawnPictures;
        }

        public string[] Skills
        {
            get
            {
                string[] skills = new string[6];
                string[] topics = new string[] { "math", "computer science", "biology", "chemistry", "literature", "philosophy" };
                for (int i = 0; i < 6; i++)
                {
                    skills[i] = topics[i] + ": " + this._studyingHours[i] + ';';
                }
                return skills;
            }
        }

        public string Study(string topic)
        {
            string[] topics = new string[] { "math", "computer science", "biology", "chemistry", "literature", "philosophy" };
            for (int i = 0; i < 6; i++)
            {
                if ((topic.ToLower()).Equals(topics[i]))
                {
                    ++_studyingHours[i];
                    return this.FirstName + ' ' + this.LastName + " has studied for 1 hour";
                }
            }
            return "This topic can not be studied";
        }

        public string Draw()
        {
            _drawnPictures++;
            return "Picture was drawn";
        }

        public virtual string Work(int hours) { return "Working..."; }
    }
}