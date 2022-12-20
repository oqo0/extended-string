using NUnit.Framework;
using ExtendedString;

namespace ExtendedStringTests;

[TestFixture]
public partial class ExtendedString
{
    [Test]
    [TestCase("", true)]
    [TestCase("  ", true)]
    [TestCase("a ", false)]
    public void IsEmptyOrWhitespace(string testString, bool expectedResult)
    {
        bool actualResult = testString.IsEmptyOrWhitespace();
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}