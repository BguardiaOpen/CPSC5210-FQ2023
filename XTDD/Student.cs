namespace XTDD
{
    public class Student  : Person
    {
        public string? Major {  get; set; }

        public Student(int idPerson, string firstName, string middleName, 
            string lastName, string? major): 
            base(idPerson, firstName, middleName, lastName)
        {            
            Major = major;
        }
    }
}
