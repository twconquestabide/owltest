using System;
using SystemsUnderTest;
using NUnit.Framework;

namespace Tests
{
    public class DateHelperTests
    {
        [Test]
        public void ConvertDateToString_ReturnsDateTimeInUKSlashFormat()
        {
            // Arrange.
            var sut = new DateHelper();
            var thirdJuly2020 = new DateTime(2020, 7,3);

            // Act.
            var result = sut.ConvertDateToString(thirdJuly2020);

            // Assert.
            Assert.That(result, Is.EqualTo("03/07/2020 00:00:00"));
        }
    }
}