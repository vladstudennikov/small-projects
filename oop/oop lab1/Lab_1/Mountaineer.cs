namespace Lab_1
{
    public class Mountaineer : Human
    {
        public Mountaineer(string firstName, string lastName, string passportID) :
            base(firstName, lastName, passportID)
        { }

        public override string Work(int hours)
        {
            return this.FirstName + ' ' + this.LastName + "climbed the mountain";
        }
    }
}