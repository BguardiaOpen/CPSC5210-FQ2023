using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTDD
{
    public interface IPerson
    {
        public int IDPerson {  get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public IPerson Add(string firstName, string middleName, string lastName);
        public IPerson Get(int id);
        public IPerson Get(string firstName, string lastName);
        public IPerson Get(bool exact, string firstPartial, string lastPartial);
        public IPerson Update(IPerson person, string? firstName, string? middleName, string? lastName);
        public IPerson Delete(IPerson person);
    }
}
