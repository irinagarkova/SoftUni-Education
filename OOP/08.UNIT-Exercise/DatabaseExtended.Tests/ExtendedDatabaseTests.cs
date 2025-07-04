namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [Test]
        public void Constructor_ShouldInitializeDatabaseWithGivenPersons()
        {
            // Arrange
            var person1 = new Person(1, "John");
            var person2 = new Person(2, "Jane");

            // Act
            var database = new Database(person1, person2);

            // Assert
            Assert.AreEqual(2, database.Count);
        }

        [Test]
        public void Add_ShouldAddPersonToDatabase()
        {
            // Arrange
            var database = new Database();
            var person = new Person(1, "John");

            // Act
            database.Add(person);

            // Assert
            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void Add_ShouldThrowException_WhenUsernameAlreadyExists()
        {
            // Arrange
            var person1 = new Person(1, "John");
            var person2 = new Person(2, "John");
            var database = new Database(person1);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(person2));
        }

        [Test]
        public void Add_ShouldThrowException_WhenIdAlreadyExists()
        {
            // Arrange
            var person1 = new Person(1, "John");
            var person2 = new Person(1, "Jane");
            var database = new Database(person1);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(person2));
        }

        [Test]
        public void Add_ShouldThrowException_WhenDatabaseIsFull()
        {
            // Arrange
            var persons = Enumerable.Range(1, 16).Select(i => new Person(i, $"User{i}")).ToArray();
            var database = new Database(persons);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(17, "OverflowUser")));
        }

        [Test]
        public void Remove_ShouldRemoveLastPersonFromDatabase()
        {
            // Arrange
            var person1 = new Person(1, "John");
            var database = new Database(person1);

            // Act
            database.Remove();

            // Assert
            Assert.AreEqual(0, database.Count);
        }

        [Test]
        public void Remove_ShouldThrowException_WhenDatabaseIsEmpty()
        {
            // Arrange
            var database = new Database();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FindByUsername_ShouldReturnPerson_WhenUsernameExists()
        {
            // Arrange
            var person = new Person(1, "John");
            var database = new Database(person);

            // Act
            var foundPerson = database.FindByUsername("John");

            // Assert
            Assert.AreEqual(person, foundPerson);
        }

        [Test]
        public void FindByUsername_ShouldThrowException_WhenUsernameDoesNotExist()
        {
            // Arrange
            var database = new Database();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("NonExistentUser"));
        }

        [Test]
        public void FindByUsername_ShouldThrowException_WhenUsernameIsNull()
        {
            // Arrange
            var database = new Database();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(null));
        }

        [Test]
        public void FindById_ShouldReturnPerson_WhenIdExists()
        {
            // Arrange
            var person = new Person(1, "John");
            var database = new Database(person);

            // Act
            var foundPerson = database.FindById(1);

            // Assert
            Assert.AreEqual(person, foundPerson);
        }

        [Test]
        public void FindById_ShouldThrowException_WhenIdDoesNotExist()
        {
            // Arrange
            var database = new Database();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.FindById(999));
        }

        [Test]
        public void FindById_ShouldThrowException_WhenIdIsNegative()
        {
            // Arrange
            var database = new Database();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-1));
        }
        private static int[] GenerateRandomInt(int length)
        {
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
                result[i] = Random.Shared.Next();
            return result;
        }
    }
}
