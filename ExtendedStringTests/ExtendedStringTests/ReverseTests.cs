using NUnit.Framework;
using ExtendedString;

namespace ExtendedStringTests;

[TestFixture]
public partial class ExtendedString
{
    [Test]
    [TestCase(null, null)]
    [TestCase("", "")]
    [TestCase("1", "1")]
    [TestCase("123", "321")]
    public void ReverseString(string testString, string expectedResult)
    {
        var actualResult = testString.Reverse();
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}