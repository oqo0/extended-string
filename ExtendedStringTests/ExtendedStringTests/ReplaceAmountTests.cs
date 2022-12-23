using NUnit.Framework;
using ExtendedString;

namespace ExtendedStringTests;

[TestFixture]
public partial class ExtendedString
{
    [Test]
    [TestCase("_11", "1", 1, "_1")]
    [TestCase("_11", "1", 2, "_")]
    [TestCase("_11", "1", 3, "_")]
    [TestCase("", "1", 3, "")]
    public void ReplaceString(string testString, string value, int replaceAmount, string expectedResult)
    {
        var actualResult = testString.ReplaceAmount(value, replaceAmount);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}