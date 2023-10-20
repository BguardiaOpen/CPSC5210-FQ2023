using Moq;
using System.Xml.Serialization;

namespace XTDD
{

    public class UnitTest1
    {
        [Fact]
        public void TestAddPerson()
        {
            // arrange
            Mock mock = new Mock<IPersonRepository>();
            IPersonRepository person = (IPersonRepository)mock.Object;
            mock.As<IPersonRepository>().Setup(p =>
                p.Add(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())
                ).Returns(new Person(1, "Bruno", "", "Guardia"));
            // act
            Person output = person.Add("Bruno", "", "Guardia");
            // assert
            Assert.Equal(1, output.IDPerson);
            Assert.Equal("Bruno", output.FirstName);
            Assert.Equal("Guardia", output.LastName);
        }

        [Fact]
        public void TestUpdatePerson()
        {
            // arrange
            Person testPerson = new Person(1, "Bruno", "", "Guardia");
            Mock mock = new Mock<IPersonRepository>();
            IPersonRepository person = (IPersonRepository)mock.Object;
            mock.As<IPersonRepository>().Setup(p =>
                p.Update(It.IsAny<Person>(), It.IsAny<string?>(), It.IsAny<string?>(), It.IsAny<string?>())
                ).Returns(new Person(testPerson.IDPerson, testPerson.FirstName,
                testPerson.MiddleName, "Robles"));
            // act
            Person output = person.Update(testPerson, null, null, "Robles");
            // assert
            Assert.Equal(1, output.IDPerson);
            Assert.Equal("Bruno", output.FirstName);
            Assert.Equal("Robles", output.LastName);
        }

        [Fact]
        public void TestAddStudent()
        {
            // arrange
            Mock mock = new Mock<IPersonRepository>();
            IPersonRepository person = (IPersonRepository)mock.Object;
            mock.As<IPersonRepository>().Setup(p =>
                p.Add(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())
                ).Returns(new Student(1, "Bruno", "", "Guardia", "CS"));
            // act
            Person output = person.Add("Bruno", "", "Guardia");
            // assert
            Assert.Equal(1, output.IDPerson);
            Assert.Equal("Bruno", output.FirstName);
            Assert.Equal("Guardia", output.LastName);
        }

    }
}