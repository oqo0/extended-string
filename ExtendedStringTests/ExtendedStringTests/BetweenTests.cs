using System;
using NUnit.Framework;
using ExtendedString;

namespace ExtendedStringTests;

[TestFixture]
public partial class ExtendedString
{
    [Test]
    [TestCase("#1#", '#', '#', "1")]
    [TestCase("", '3', '#', null)]
    public void BetweenChars(string testString, char openChar, char closeChar, string expectedResult)
    {
        string actualResult = testString.Between(openChar, closeChar);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
    
    [Test]
    [TestCase("#1@", "#", "@", "1")]
    [TestCase("", "", "", null)]
    public void BetweenStrings(string testString, string openStr, string closeStr, string expectedResult)
    {
        string actualResult = testString.Between(openStr, closeStr, StringComparison.Ordinal);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}