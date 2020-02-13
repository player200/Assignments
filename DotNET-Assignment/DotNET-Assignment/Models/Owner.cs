namespace DotNET_Assignment.Models
{
    public class Owner
    {
        public Owner(string firstName, string lastName)
        {
            this.FristName = firstName;
            this.LastName = lastName;
        }

        public string FristName { get; private set; }

        public string LastName { get; private set; }
    }
}