using System;
using NUnit.Framework;
using ExtendedString;

namespace ExtendedStringTests;

[TestFixture]
public partial class ExtendedString
{
    [Test]
    [TestCase("1", 3, " 1 ")]
    [TestCase("1", 4, " 1 ")]
    [TestCase("1", 0, "1")]
    public void CenterString(string testString, int width, string expectedResult)
    {
        string actualResult = testString.Center(width);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}