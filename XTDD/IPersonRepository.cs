namespace XTDD
{
    public interface IPersonRepository
    {
        public Person Add(string firstName, string middleName, string lastName);
        public Person Get(int id);
        public Person Get(string firstName, string lastName);
        public Person Get(bool exact, string firstPartial, string lastPartial);
        public Person Update(Person person, string? firstName, string? middleName, string? lastName);
        public Person Delete(Person person);
    }
}
