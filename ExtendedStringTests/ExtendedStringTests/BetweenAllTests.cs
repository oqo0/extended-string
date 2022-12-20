using System;
using System.Collections.Generic;
using NUnit.Framework;
using ExtendedString;

namespace ExtendedStringTests;

[TestFixture]
public partial class ExtendedString
{
    [Test]
    [TestCase("#1@ #2@", '#', '@', new[] { "1", "2" })]
    [TestCase("#0@", '#', '@', new[] { "0" })]
    [TestCase("", '3', '#', null)]
    public void BetweenAllChars(string testString, char openChar, char closeChar, IEnumerable<String> expectedResult)
    {
        var actualResult = testString.BetweenAll(openChar, closeChar);
        
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    [TestCase("#1@ #2@", "#", "@", new[] { "1", "2" })]
    [TestCase("#0@", "#", "@", new[] { "0" })]
    [TestCase("", "#", "@", null)]
    public void BetweenAllStrings(string testString, string openStr, string closeStr, IEnumerable<String> expectedResult)
    {
        var actualResult = testString.BetweenAll(openStr, closeStr, StringComparison.Ordinal);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}