namespace XTDD
{
    public class Person
    {
        private static int _nextPerson = 1;

        public int IDPerson { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }


        public Person(int idPerson, string firstName, string middleName, string lastName)
        {
            IDPerson = idPerson;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public Person(string firstName, string middleName, string lastName)
        {
            IDPerson = _nextPerson++;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}
