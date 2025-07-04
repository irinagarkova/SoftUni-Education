namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        private const int MaxCapasity = 16;

        [TestCase(0)]
        [TestCase(10)]
        [TestCase(MaxCapasity)]
        public void Database_Should_Be_Created_Succesfully(int elementsCount)
        {
            int[] originalElements = GenerateRandomInt(elementsCount);

            Database database = new Database(originalElements); //създаваме инстанция

            Assert.AreEqual(elementsCount, database.Count);
            Assert.AreEqual(originalElements, database.Fetch()); //дали съдържанието е еквивалентно с fetch
        }

        [TestCase(MaxCapasity + 1)]
        [TestCase(50)]
        public void Database_Should_Not_Be_Created_If_Elements_Is_To_Much(int elementsCount)
        {

            int[] elements = GenerateRandomInt(elementsCount);

            Assert.Throws<InvalidOperationException>(()
                => new Database(elements)); //да видим дали ще хвърли грешката

        }

        [Test]
        public void Add_Should_Work_Correct()
        {
            Database database = new Database();

            List<int> addedNumbers = new List<int>(); //симулираме подредбата

            for (int i = 0; i < MaxCapasity; i++)
            {
                int number = Random.Shared.Next();
                database.Add(number);
                addedNumbers.Add(number);

                Assert.AreEqual(i + 1, database.Count);
                Assert.AreEqual(addedNumbers, database.Fetch()); //added да бъде == на Fetch
            }

        }
        [Test]
        public void Add_Should_Throw_If_Database_Is_Already_Filled()
        {

            //Arrange
            int[] elements = GenerateRandomInt(MaxCapasity);

            //Act
            Database database = new Database(elements);

            //Assert
            Assert.Throws<InvalidOperationException>(()
                => database.Add(Random.Shared.Next()));
        }

        [Test]
        public void Remove_Should_Work_Correctly()
        {
            int[] elements = GenerateRandomInt(MaxCapasity);

            Database database = new Database(elements);

            for (int i = 0; i < elements.Length; i++)
            {
                database.Remove();

                int expected = elements.Length - (i + 1);
                Assert.AreEqual(expected, database.Count);
                Assert.AreEqual(elements.Take(expected), database.Fetch());
            }
        }

        [Test]
        public void Remove_Should_Throw_If_Database_Is_Empty()
        {
            Database database = new Database();
            Assert.Throws<InvalidOperationException>(() => database.Remove());
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
