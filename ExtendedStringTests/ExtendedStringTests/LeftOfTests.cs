using NUnit.Framework;
using ExtendedString;

namespace ExtendedStringTests;

[TestFixture]
public partial class ExtendedString
{
    [Test]
    [TestCase("01", '1', "0")]
    [TestCase("1", '1', null)]
    [TestCase("", '1', null)]
    public void LeftOfChar(string testString, char character, string expectedResult)
    {
        var actualResult = testString.LeftOf(character);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
    
    [Test]
    [TestCase("01", "1", "0")]
    [TestCase("0012", "12", "00")]
    [TestCase("1", "1", null)]
    [TestCase("", "1", null)]
    public void LeftOfString(string testString, string value, string expectedResult)
    {
        var actualResult = testString.LeftOf(value);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}