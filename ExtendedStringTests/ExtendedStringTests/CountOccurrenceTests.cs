using NUnit.Framework;
using ExtendedString;

namespace ExtendedStringTests;

[TestFixture]
public partial class ExtendedString
{
    [Test]
    [TestCase("2", "2", 1)]
    [TestCase("", "2", null)]
    public void CountOccurrence(string testString, string countedString, int expectedResult)
    {
        int actualResult = testString.CountOccurrence(countedString);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}