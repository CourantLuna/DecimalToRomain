using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecimalToRomain;
using NUnit.Framework;

[TestFixture]
public class RomanNumeralConverterTests
{
    [Test]
    [TestCase(1, "I")]
    [TestCase(3, "III")]
    [TestCase(58, "LVIII")]
    [TestCase(1994, "MCMXCIV")]
    [TestCase(3999, "MMMCMXCIX")]
    public void DecimalToRoman_ConvertsCorrectly(int input, string expected)
    {
        // Arrange
        RomanNumeralConverter converter = new RomanNumeralConverter();

        // Act
        string result = converter.DecimalToRoman(input);

        // Assert
        Assert.Equals(expected, result);
    }
}
