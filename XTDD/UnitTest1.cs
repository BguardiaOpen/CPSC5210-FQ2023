using Moq;
using System.Xml.Serialization;

namespace XTDD
{

    public class UnitTest1
    {
        private class TestPerson:IPerson {
            public TestPerson(int idPerson, string firstName,
                string middleName, string lastName)
            {
                IDPerson = idPerson;
                FirstName = firstName;
                MiddleName = middleName;
                LastName = lastName;
            }

            public int IDPerson { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public IPerson Add(string firstName, string middleName, string lastName)
            {
                return default;
            }
            public IPerson Get(int id)
            {
                return default;
            }

            public IPerson Get(string firstName, string lastName)
            {
                return default;
            }
        
            public IPerson Get(bool exact, string firstPartial, string lastPartial)
            {
                return default;
            }
            public IPerson Update(IPerson person, string? firstName, string? middleName, string? lastName)
            {
                return default;
            }
            
            public IPerson Delete(IPerson person)
            {
                return default;
            }
        }

        [Fact]
        public void TestAddPerson()
        {
            // arrange
            Mock mock = new Mock<IPerson>();
            IPerson person = (IPerson)mock.Object;
            mock.As<IPerson>().Setup(p =>
                p.Add(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())
                ).Returns(new TestPerson(1,"Bruno","","Guardia"));
            // act
            IPerson output = person.Add("Bruno", "", "Guardia");
            // assert
            Assert.Equal(1, output.IDPerson);
            Assert.Equal("Bruno", output.FirstName);
            Assert.Equal("Guardia", output.LastName);
        }
    }
}