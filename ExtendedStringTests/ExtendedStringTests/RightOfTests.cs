using NUnit.Framework;
using ExtendedString;

namespace ExtendedStringTests;

[TestFixture]
public partial class ExtendedString
{
    [Test]
    [TestCase("10", '1', "0")]
    [TestCase("1", '1', null)]
    [TestCase("", '1', null)]
    public void RightOfChar(string testString, char character, string expectedResult)
    {
        var actualResult = testString.RightOf(character);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
    
    [Test]
    [TestCase("10", "1", "0")]
    [TestCase("1200", "12", "00")]
    [TestCase("1", "1", null)]
    [TestCase("", "1", null)]
    public void RightOfString(string testString, string value, string expectedResult)
    {
        var actualResult = testString.RightOf(value);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}