using NUnit.Framework;
using System.Collections.Generic;
using SystemsUnderTest;
using SystemsUnderTest.Model;

namespace Tests
{
    public class JsonSerializerTests
    {
        [Test]
        public void WhenBookObjectIsSerialized_ThenReturnedStringIsAsExpected()
        {
            // Arrange.
            var bookObject = new Book
            {
                Title = "The Big Book of CSharp",
                Authors = new List<string>
                {
                    "Terry",
                    "Duncan"
                }
            };

            var jsonSerializer = new JsonSerializer();

            // Act.
            var objectAsString = jsonSerializer.Serialize(bookObject);

            // Assert.
            Assert.That(objectAsString, Is.EqualTo("{\"Title\":\"The Big Book of CSharp\",\"Authors\": [\"Terry\",\"Duncan\"]}"));
        }
    }
}
