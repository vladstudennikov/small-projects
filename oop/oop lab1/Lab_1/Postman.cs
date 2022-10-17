namespace Lab_1
{
    public class Postman : Human
    {
        private int workExperience = 0;

        public int WorkExperience
        {
            get => workExperience;
        }

        public Postman(string firstName, string lastName, string passportID) :
            base(firstName, lastName, passportID)
        { }

        public override string Work(int hours)
        {
            workExperience += hours;
            return this.FirstName + ' ' + this.LastName + "worked as a postman for " + hours + " hours";
        }
    }
}
